using Newtonsoft.Json;
using OMRON.Compolet.CIP;
using SKTRFIDLIB.Model;
using SKTRFIDLIB.Service;
using SKTRFIDLIBRARY.Interface;
using SKTRFIDLIBRARY.Model;
using SKTRFIDLIBRARY.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKTRFIDSERVER
{
    public partial class Form1 : Form
    {
        public string mode = "";
        public int dump = 0;
        public string server = "";
        public int phase = 0;
        static List<Reader> Readers = new List<Reader>();
        static RfidTag SelectedTag = null;
        Reader readers = null;
        private IRFID RFID;
        private ITagLog TagLog;
        CJ2Compolet cj2;
        private ISetting Settings;
        private IAPI API;
        private IAccessory Accessory;
        SettingModel Setting;
        RFIDModel rfid = null;
        string statusAllergen = "Yes";

        Label txtMsg = new Label();
        Button btnOK = new Button();
        Button btnNo = new Button();
        Button btnYes = new Button();
        Form newForm = new Form();

        string tag_id = string.Empty;
        bool CheckInternet = true;

        string rfid_code = string.Empty;
        string license_plate = string.Empty;
        string truck_type = string.Empty;
        string weight_code = string.Empty;
        string cane_type = string.Empty;
        string weight_type = string.Empty;
        string queue_status = string.Empty;
        string dump_no = string.Empty;

        //bool check_tag_original = true;

        string queue_trig = string.Empty;
        DataModel data_dump = new DataModel();
        public Form1(string _mode ,string _server, string _dump,string _phase)
        {
            InitializeComponent();
            mode = _mode;
            dump = Convert.ToInt32(_dump);
            server = _server;
            phase = Convert.ToInt32(_phase);
            RFID = new RFIDService(phase);
            Settings = new SettingService(phase);
            rfid = new RFIDModel();
            TagLog = new TagLogService(phase);
            API = new APIService();
            Accessory = new AccessoryService();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {               
                string path = Directory.GetCurrentDirectory();
                //Get Setting
                Setting = Settings.GetSetting();
                
                if (Setting.no == 1)
                {
                    this.Text = mode + " DUMP " + dump;
                }
                else
                {
                    return;
                }
                
                // PLC
                cj2 = new CJ2Compolet();
                cj2.ConnectionType = ConnectionType.UCMM;              
                cj2.UseRoutePath = false;
                cj2.PeerAddress = Setting.ip_plc;
                cj2.LocalPort = 2;
                cj2.Active = true;


                if (await OpcUaService.Instance.ConnectAsync(server, 4840))
                {
                    string ident = "";
                    if (mode == "AUTO") // Auto Mode
                    {
                        List<string> idents = new List<string>();
                        idents.Add("Ident 0");
                        idents.Add("Ident 1");
                        idents.Add("Ident 2");
                        idents.Add("Ident 3");

                        /*
                          Phase 1 DUMP [1-7]
                             Controller #1
                             DUMP1 Ident 0
                             DUMP2 Ident 1
                             DUMP3 Ident 2
                             DUMP4 Ident 3

                             Controller #2
                             DUMP5 Ident 0
                             DUMP6 Ident 1
                             DUMP7 Ident 2
                             Common DUMP Ident 3

                          Phase 2 DUMP [8-13]
                             Controller #1
                             DUMP8 Ident 0
                             DUMP9 Ident 1
                             DUMP10 Ident 2
                             DUMP11 Ident 3

                             Controller #2
                             DUMP12 Ident 0
                             DUMP13 Ident 1
                             Common DUMP Ident 3
                        */

                        if (phase == 1)
                        {
                            if (server == Setting.ip1)
                            {
                                ident = idents[dump - 1];
                            }
                            if (server == Setting.ip2)
                            {
                                ident = idents[dump - 5];
                            }
                        }
                        if (phase == 2)
                        {
                            if (server == Setting.ip1)
                            {
                                ident = idents[dump - (1 + 7)];
                            }
                            if (server == Setting.ip2)
                            {
                                ident = idents[dump - (5 + 7)];
                            }
                        }
                    }
                    else // Common Mode
                    {
                        ident = "Ident 3";   // COMMON RFID
                    }

                    RefreshReaderListCommandExecute();

                    readers = Readers.Where(w => w.Ident == ident).FirstOrDefault();

                    label1.Text = "DUMP " + dump;

                    if (readers != null)
                    {
                        Reader SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);

                        #region SCAN TAG

                        bool status_scan = false;


                        while (!status_scan)
                        {
                            try
                            {
                                SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);
                                var tuple = await OpcUaService.Instance.ScanAsync(SelectedReader, 1000, 1);
                                if (tuple.Item1.Status == "SUCCESS")
                                {
                                    //if (check_tag_original)
                                    //{
                                        tag_id = tuple.Item1.Tags[0].IdentiferString;
                                        SelectedTag = tuple.Item1.Tags[0];

                                       // check_tag_original = false;
                                    //}

                                    string _rfid = tag_id.Substring(0, 4); // RFID
                                    if (_rfid == "0000") // Check Invalid RFID
                                    {
                                        try
                                        {
                                            SoundPlayer dump_wave_file = new SoundPlayer();
                                            dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\d{dump}.wav");
                                            dump_wave_file.PlaySync();
                                        }
                                        catch
                                        {

                                        }
                                        try
                                        {
                                            SoundPlayer dump_wave_file = new SoundPlayer();
                                            dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\nowrite.wav");
                                            dump_wave_file.PlaySync();
                                        }
                                        catch
                                        {

                                        }
                                        return;
                                    }
                                    else // Valid RFID
                                    {
                                        if (tag_id.Length == 24) // Check Valid RFID Card  24 Charector
                                        {
                                            // Insert Data Log RFID Original
                                            string rfid_ = int.Parse(tag_id.Substring(0, 4), System.Globalization.NumberStyles.HexNumber).ToString().PadLeft(6, '0');
                                            TagLogModel taglog = new TagLogModel()
                                            {
                                                tag = tag_id,
                                                tag_date = DateTime.Now,
                                                rfid = rfid_
                                            };
                                            string message = TagLog.InsertTag(taglog);

                                            rfid_code = tag_id.Substring(0, 4);
                                            license_plate = tag_id.Substring(4, 10);
                                            truck_type = tag_id.Substring(14, 1);
                                            weight_code = tag_id.Substring(15, 5);
                                            cane_type = tag_id.Substring(20, 1);
                                            weight_type = tag_id.Substring(21, 1);
                                            queue_status = tag_id.Substring(22, 1);
                                            dump_no = tag_id.Substring(23, 1);
                                        }
                                        else
                                        {
                                            try
                                            {
                                                SoundPlayer dump_wave_file = new SoundPlayer();
                                                dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\d{dump}.wav");
                                                dump_wave_file.PlaySync();
                                            }
                                            catch
                                            {

                                            }
                                            try
                                            {
                                                SoundPlayer dump_wave_file = new SoundPlayer();
                                                dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\noscan.wav");
                                                dump_wave_file.PlaySync();
                                            }
                                            catch
                                            {

                                            }
                                            return;
                                        }

                                        data_dump = new DataModel();
                                        data_dump.dump_id = dump;
                                        data_dump.area_id = Setting.area_id;
                                        data_dump.crop_year = Setting.crop_year;
                                        data_dump.rfid = int.Parse(rfid_code, System.Globalization.NumberStyles.HexNumber).ToString().PadLeft(6, '0');

                                        
                                        bool check_response_api = false;

                                        while (!check_response_api)
                                        {
                                            CheckInternet = checkInternet();
                                            if (CheckInternet)  // Online Read data from api
                                            {
                                                // Call Data From API
                                                rfid = await API.CallAPI(data_dump);
                                                Thread.Sleep(200);
                                                if (rfid.Data.Count > 0)
                                                {
                                                    if (rfid.Data[0].Barcode != "1") // Check Valid Barcode
                                                    {
                                                        //Update Value from API
                                                        weight_code = Int32.Parse(rfid.Data[0].Barcode).ToString("x").ToUpper(); // Barcode Convert int to hex
                                                        cane_type = rfid.Data[0].CaneType;
                                                    }
                                                    check_response_api = true;
                                                }
                                            }
                                            else // Offline Read From RFID Card
                                            {
                                                rfid = Accessory.ReadRFIDCard(tag_id);
                                                check_response_api = true;
                                            }                                           
                                        }
                                    }

                                    Thread.Sleep(1000);

                                    #endregion SCAN TAG


                                    #region WRITE TAG


                                    //string data_write = tag_id;
                                    string data_write = "3" + dump.ToString("x").ToUpper();
                                    byte[] data = Enumerable.Range(0, 1 * 2)
                                                    .Where(x => x % 2 == 0)
                                                    .Select(x => Convert.ToByte(data_write.Substring(x, 2), 16))
                                                    .ToArray();
                                    OpcUaStatusCode status_code;

                                    var tag_stringBuilder = new StringBuilder(tag_id);
                                    tag_stringBuilder.Remove(22, 1);
                                    tag_stringBuilder.Insert(22, "3");
                                    tag_stringBuilder.Remove(23, 1);
                                    tag_stringBuilder.Insert(23, dump.ToString("x").ToUpper());
                                    tag_id = tag_stringBuilder.ToString();

                                    var result_write = OpcUaService.Instance.WriteTag(SelectedReader, SelectedTag, 11, data, out status_code);
                                    Thread.Sleep(100);
                                    if (status_code.IsGood)
                                    {
                                        //Re - Check Write
                                        if (readers != null)
                                        {
                                            SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);
                                            var tuple1 = await OpcUaService.Instance.ScanAsync(SelectedReader, 1000, 1);
                                            if (tuple1.Item1.Status == "SUCCESS")
                                            {
                                                //tag_id = tuple1.Item1.Tags[0].IdentiferString;
                                                SelectedTag = tuple1.Item1.Tags[0];

                                                string _read_tag = "";
                                                try
                                                {
                                                    var result_read = await OpcUaService.Instance.ReadTagAsync(SelectedReader, SelectedTag, 0, 13);
                                                    if (result_read.Item2.IsGood)
                                                    {
                                                        _read_tag = BitConverter.ToString(result_read.Item1).Replace("-", string.Empty);
                                                        if (_read_tag.Contains(tag_id))
                                                        {
                                                            // Send Data To PLC
                                                            if (phase == 1)
                                                            {
                                                                string[] dump_plc_caneType = new string[7] { "TY_BF_D1" ,
                                                                                                                "TY_BF_D2" ,
                                                                                                                "TY_BF_D3" ,
                                                                                                                "TY_BF_D4" ,
                                                                                                                "TY_BF_D5" ,
                                                                                                                "TY_BF_D6" ,
                                                                                                                "TY_BF_D7" };
                                                                string _caneType = "0"; // สด
                                                                if (cane_type == "1" || cane_type == "3") // ไฟไหม้
                                                                {
                                                                    _caneType = "1";
                                                                }
                                                                cj2.WriteVariable(dump_plc_caneType[dump - 1], _caneType);

                                                                string[] dump_plc_Barcode = new string[7] { "Bar_ID1" ,
                                                                                                                "Bar_ID2" ,
                                                                                                                "Bar_ID3" ,
                                                                                                                "Bar_ID4" ,
                                                                                                                "Bar_ID5" ,
                                                                                                                "Bar_ID6" ,
                                                                                                                "Bar_ID7" };
                                                                cj2.WriteVariable(dump_plc_Barcode[dump - 1], int.Parse(weight_code, System.Globalization.NumberStyles.HexNumber).ToString());
                                                            }

                                                            if (phase == 2)
                                                            {
                                                                string[] dump_plc_caneType = new string[7] { "TY_BF_D1" ,
                                                                                                                    "TY_BF_D2" ,
                                                                                                                    "TY_BF_D3" ,
                                                                                                                    "TY_BF_D4" ,
                                                                                                                    "TY_BF_D5" ,
                                                                                                                    "TY_BF_D6" ,
                                                                                                                    "TY_BF_D7" };
                                                                string _caneType = "0"; // สด
                                                                if (cane_type == "1" || cane_type == "3") // ไฟไหม้
                                                                {
                                                                    _caneType = "1";
                                                                }
                                                                cj2.WriteVariable(dump_plc_caneType[dump - (1 + 7)], _caneType);

                                                                string[] dump_plc_Barcode = new string[7] { "Bar_ID1" ,
                                                                                                                "Bar_ID2" ,
                                                                                                                "Bar_ID3" ,
                                                                                                                "Bar_ID4" ,
                                                                                                                "Bar_ID5" ,
                                                                                                                "Bar_ID6" ,
                                                                                                                "Bar_ID7" };
                                                                cj2.WriteVariable(dump_plc_Barcode[dump - (1 + 7)], int.Parse(weight_code, System.Globalization.NumberStyles.HexNumber).ToString());
                                                            }
                                                            status_scan = true;
                                                            //status_write = true;
                                                            //MessageBox.Show("Write Success ", data_write);
                                                        }
                                                    }
                                                }
                                                catch
                                                {
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch
                            {

                            }
                        }

                        #endregion WRITE TAG

                        DateTime now = DateTime.Now;

                        //Update Data to Local Database
                        DataModel dataDump = new DataModel();
                        dataDump.dump_id = dump;
                        dataDump.area_id = Setting.area_id;
                        dataDump.crop_year = Setting.crop_year;
                        dataDump.rfid = data_dump.rfid;
                        dataDump.truck_number = rfid.Data[0].TruckNumber;
                        dataDump.farmer_name = rfid.Data[0].FarmerName;
                        dataDump.rfid_lastdate = now;
                        dataDump.cane_type = Convert.ToInt32(rfid.Data[0].CaneType);
                        dataDump.allergen = rfid.Data[0].Allergen;
                        dataDump.barcode = rfid.Data[0].Barcode;
                        dataDump.truck_type = Convert.ToInt32(truck_type);
                        dataDump.weight_type = Convert.ToInt32(weight_type);
                        dataDump.queue_status = 3;
                        string message_update = RFID.UpdateRFID(dataDump);

                        #region Allergen

                        //Check Allergen
                        if (rfid.Data[0].Allergen.ToLower().Trim() == "yes")
                        {
                            //Message Box Custom
                            TextAllergen("Allergen", "ดัมพ์ " + dump + " ทะเบียน " + rfid.Data[0].TruckNumber, "พบสารก่อให้เกิดภูมิแพ้");
                        }

                        #endregion Allergen
     
                    }
                    else
                    {
                        try
                        {
                            SoundPlayer dump_wave_file = new SoundPlayer();
                            dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\d{dump}.wav");
                            dump_wave_file.PlaySync();
                        }
                        catch
                        {

                        }
                        try
                        {
                            SoundPlayer dump_wave_file = new SoundPlayer();
                            dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\noscan.wav");
                            dump_wave_file.PlaySync();
                        }
                        catch
                        {

                        }
                    }
                }
            }
            catch (OpcUaServiceException ex)
            {
                string path = Directory.GetCurrentDirectory();
                try
                {
                    SoundPlayer dump_wave_file = new SoundPlayer();
                    dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\d{dump}.wav");
                    dump_wave_file.PlaySync();
                }
                catch
                {

                }
                try
                {
                    SoundPlayer dump_wave_file = new SoundPlayer();
                    dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\noscan.wav");
                    dump_wave_file.PlaySync();
                }
                catch
                {

                }

                string loca = @"D:\log.txt";
                File.AppendAllText(loca, server + " " + dump + " " + DateTime.Now + " " + ex.Message + Environment.NewLine);
            }
            finally
            {
                OpcUaService.Instance.Disconnect();
                this.Close();
            }
        }
           
        private static void RefreshReaderListCommandExecute()
        {
            Readers.Clear();
            try
            {
                var ReaderList = OpcUaService.Instance.GetAllReader();
                for (int i = 0; i < ReaderList.Count; i++)
                {
                    Readers.Add(ReaderList[i]);
                }
            }
            catch (OpcUaServiceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private  void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpcUaService.Instance.Disconnect();
            cj2.Active = false;
            cj2.Dispose();
        }

        private DialogResult spawnForm(string title, string text1, string text2)
        {
            newForm.Text = title;
            newForm.Controls.Add(txtMsg);
            newForm.BackColor = Color.Blue;
            txtMsg.AutoSize = true;
            txtMsg.Text = text1 + Environment.NewLine + text2;
            newForm.Width = 500;
            newForm.Height = 420;
            txtMsg.Location = new Point(newForm.Width / 2 - 220, 40);
            txtMsg.Font = new Font("Angsana New", 40f);
            txtMsg.TextAlign = ContentAlignment.MiddleCenter;
            txtMsg.ForeColor = Color.Black;

            newForm.Controls.Add(btnYes);
            btnYes.Text = "มี";
            btnYes.Width = 150;
            btnYes.Height = 80;
            btnYes.Font = new Font("Angsana New", 30f);
            btnYes.BackColor = Color.Red;
            btnYes.Location = new Point(newForm.Width / 2 - 190, 190);
            btnYes.Click += BtnYes_Click;
            btnYes.Cursor = Cursors.Hand;

            newForm.Controls.Add(btnNo);
            btnNo.Text = "ไม่มี";
            btnNo.Width = 150;
            btnNo.Height = 80;
            btnNo.Font = new Font("Angsana New", 30f);
            btnNo.BackColor = Color.White;
            btnNo.Location = new Point(newForm.Width / 2 + 40, 190);
            btnNo.Click += BtnNo_Click;
            btnNo.Cursor = Cursors.Hand;

            newForm.Controls.Add(btnOK);
            btnOK.Text = "ตรวจสอบ";
            btnOK.Width = 250;
            btnOK.Height = 100;
            btnOK.Font = new Font("Angsana New", 40f);
            btnOK.BackColor = Color.White;
            btnOK.Location = new Point(newForm.Width / 2 - 120, 300);
            btnOK.Click += BtnOK_Click;
            btnOK.Cursor = Cursors.Hand;

            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.MaximizeBox = false;
            newForm.MinimizeBox = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.TopMost = true;

            return newForm.ShowDialog();
        }
        public DialogResult TextAllergen(string title, string text1, string text2)
        {
            return spawnForm(title, text1, text2);
        }
        private void BtnNo_Click(object sender, EventArgs e)
        {
            statusAllergen = "No";
            btnYes.BackColor = Color.White;
            btnNo.BackColor = Color.GreenYellow;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            statusAllergen = "Yes";
            btnYes.BackColor = Color.Red;
            btnNo.BackColor = Color.White;
        }

        private async void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("ต้องการยืนยันหรือไม่?", "SKT RFID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                //Check Local Internet
                bool _checkInternet = checkInternet();
                if (_checkInternet)  // Online Read data from api
                {
                    //Call Form Alert Allergen
                    SettingModel setting = Settings.GetSetting();
                    string alleD = "0";
                    if (statusAllergen == "Yes")
                    {
                        alleD = "1";
                    }

                    //Update Allergen to API
                    await API.UpdateAlled(setting.area_id.ToString(), setting.crop_year, rfid.Data[0].Barcode, alleD);
                }

                // Update Allergen Local Database
                DataModel data = new DataModel()
                {
                    dump_id = dump,
                    allergen = statusAllergen,
                    barcode = rfid.Data[0].Barcode,
                    area_id = Setting.area_id,
                    crop_year = Setting.crop_year
                };
                
                RFID.UpdateRFIDAllergen(data);
                RFID.UpdateRFIDAllergenLog(data);
                newForm.Close();
            }
        }
        bool checkInternet()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("http://10.43.6.33/"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }        
    }
}
