using Newtonsoft.Json;
using OMRON.Compolet.CIP;
using SKTRFIDLIBRARY.Interface;
using SKTRFIDLIBRARY.Model;
using SKTRFIDLIBRARY.Service;
using SKTRFIDLIB.Model;
using SKTRFIDLIB.Service;
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

namespace SKTRFIDCOMMON
{
    public partial class Form1 : Form
    {
        public int dump = 0;
        public string server = "";
        public int phase = 0;
        CJ2Compolet cj2;
        static List<Reader> Readers = new List<Reader>();
        static RfidTag SelectedTag = null;
        Reader readers = null;
        private IRFID RFID;
        private ITagLog TagLog;
        private ISetting Settings;
        private IAPI API;
        private IAccessory Accessory;
        SettingModel Setting;
        string statusAllergen = "Yes";
        RFIDModel rfid;

        Label txtMsg = new Label();
        Button btnOK = new Button();
        Button btnNo = new Button();
        Button btnYes = new Button();
        Form newForm = new Form();
        public Form1(string _dump,string _phase)
        {
            InitializeComponent();
            dump = Convert.ToInt32(_dump);
            phase = Convert.ToInt32(_phase);
            Settings = new SettingService(phase);          
            RFID = new RFIDService(phase);
            TagLog = new TagLogService(phase);
            API = new APIService();
            Accessory = new AccessoryService();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Get Setting
                Setting = Settings.GetSetting();
                if (Setting.no == 1)
                {
                    server = Setting.ip2;
                    this.Text = server + " : " + dump;
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
                    string ident = "Ident 3";
                    string path = Directory.GetCurrentDirectory();
                    RefreshReaderListCommandExecute();

                    readers = Readers.Where(w => w.Ident == ident).FirstOrDefault();


                    label1.Text = "DUMP " + dump;

                    if (readers != null)
                    {
                        Reader SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);

                        #region WRITE TAG
                        //Write Tag
                        bool status_write = false;

                        string rfid_code = string.Empty;
                        string license_plate1 = string.Empty;
                        string license_plate2 = string.Empty;
                        string license_plate3 = string.Empty;
                        string truck_type = string.Empty;
                        string weight_code = string.Empty;
                        string cane_type = string.Empty;
                        string weight_type = string.Empty;
                        string queue_status = string.Empty;
                        string dump_no = string.Empty;

                        string tag_id = string.Empty;

                        string origin_tag = string.Empty;
                        bool checkOnceTag = true;
                        while (status_write == false)
                        {
                            try
                            {
                                if (readers != null)
                                {
                                    SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);
                                    var tuple = await OpcUaService.Instance.ScanAsync(SelectedReader, 1, 1);
                                    if (tuple.Item1.Status == "SUCCESS")
                                    {
                                        tag_id = tuple.Item1.Tags[0].IdentiferString;
                                        SelectedTag = tuple.Item1.Tags[0];
                                        if (checkOnceTag)
                                        {
                                            origin_tag = tag_id;
                                            checkOnceTag = false;
                                        }

                                        if (origin_tag.Length >= 12 * 2)
                                        {
                                            rfid_code = origin_tag.Substring(0, 4);
                                            license_plate1 = origin_tag.Substring(4, 4);
                                            license_plate2 = origin_tag.Substring(8, 2);
                                            license_plate3 = origin_tag.Substring(10, 4);
                                            truck_type = origin_tag.Substring(14, 1);
                                            weight_code = origin_tag.Substring(15, 5);
                                            cane_type = origin_tag.Substring(20, 1);
                                            weight_type = origin_tag.Substring(21, 1);
                                            queue_status = origin_tag.Substring(22, 1);
                                            dump_no = origin_tag.Substring(23, 1);
                                        }
                                        else
                                        {
                                            try
                                            {
                                                SoundPlayer dump_wave_file = new SoundPlayer();
                                                dump_wave_file.SoundLocation = Path.Combine(path, $"voice\\noscan.wav");
                                                dump_wave_file.PlaySync();
                                            }
                                            catch
                                            {

                                            }
                                            return;
                                        }

                                        queue_status = "3";
                                        dump_no = dump.ToString("x").ToUpper();
                                        //string data_write = "178C8375510A4F129E812031";
                                        string data_write = rfid_code +
                                                            license_plate1 +
                                                            license_plate2 +
                                                            license_plate3 +
                                                            truck_type +
                                                            weight_code +
                                                            cane_type +
                                                            weight_type +
                                                            queue_status +
                                                            dump_no;
                                        byte[] data = Enumerable.Range(0, 12 * 2)
                                                        .Where(x => x % 2 == 0)
                                                        .Select(x => Convert.ToByte(data_write.Substring(x, 2), 16))
                                                        .ToArray();

                                        var result_write = await OpcUaService.Instance.WriteTagAsync(SelectedReader, SelectedTag, 0, data);
                                        Thread.Sleep(500);
                                        if (result_write.Item2.IsGood)
                                        {
                                            //Re - Check Write
                                            if (readers != null)
                                            {
                                                SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);
                                                var tuple1 = await OpcUaService.Instance.ScanAsync(SelectedReader, 1, 1);
                                                if (tuple1.Item1.Status == "SUCCESS")
                                                {
                                                    tag_id = tuple1.Item1.Tags[0].IdentiferString;
                                                    SelectedTag = tuple1.Item1.Tags[0];

                                                    string _read_tag = "";
                                                    try
                                                    {
                                                        var result_read = await OpcUaService.Instance.ReadTagAsync(SelectedReader, SelectedTag, 0, 13);
                                                        if (result_read.Item2.IsGood)
                                                        {
                                                            _read_tag = BitConverter.ToString(result_read.Item1).Replace("-", string.Empty);
                                                            if (_read_tag.Contains(data_write))
                                                            {
                                                                // Insert Data Log RFID
                                                                string _rfid = int.Parse(origin_tag.Substring(0, 4), System.Globalization.NumberStyles.HexNumber).ToString().PadLeft(6, '0');
                                                                TagLogModel taglog = new TagLogModel()
                                                                {
                                                                    tag = origin_tag,
                                                                    tag_date = DateTime.Now,
                                                                    rfid = _rfid
                                                                };
                                                                string message = TagLog.InsertTag(taglog);

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
                                                                status_write = true;

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
                            }

                            catch
                            {
                                //string loca = @"D:\log.txt";
                                //File.AppendAllText(loca, server + " " + dump + " " + DateTime.Now + " " + ex.Message + Environment.NewLine);
                            }

                            #endregion WRITE TAG

                            #region API AND Database

                            DataModel data_dump = new DataModel();
                            data_dump.dump_id = dump;
                            data_dump.area_id = Setting.area_id;
                            data_dump.crop_year = Setting.crop_year;
                            data_dump.rfid = int.Parse(rfid_code, System.Globalization.NumberStyles.HexNumber).ToString().PadLeft(6, '0');

                            // Run API Service
                            bool _checkInternet = checkInternet();
                            if (_checkInternet)
                            {
                                // Call Data From API
                                rfid = await API.CallAPI(data_dump);

                                //Insert Data to API
                                DataUpdateModel dataInsert = await API.InsertDataAPI(Setting.area_id, Setting.crop_year, rfid.Data[0].Barcode, phase, dump, "ADD");
                            }
                            else // Offline Read data from rfid card
                            {
                                rfid = Accessory.ReadRFIDCard(origin_tag);
                                try
                                {
                                    SoundPlayer dump_wave_file = new SoundPlayer();
                                    dump_wave_file.SoundLocation = Path.Combine(path, $"VOICE_DUMP\\noserver.wav");
                                    dump_wave_file.PlaySync();
                                }
                                catch
                                {

                                }
                            }

                            DateTime now = DateTime.Now;
                            DataModel dataDump = new DataModel();
                            dataDump.dump_id = dump;
                            dataDump.area_id = Setting.area_id;
                            dataDump.crop_year = Setting.crop_year;
                            dataDump.rfid = data_dump.rfid;
                            dataDump.truck_number = rfid.Data[0].TruckNumber;
                            dataDump.farmer_name = rfid.Data[0].FarmerName;
                            dataDump.rfid_lastdate = now;
                            dataDump.cane_type = Int32.Parse(rfid.Data[0].CaneType);
                            dataDump.allergen = rfid.Data[0].Allergen;
                            dataDump.barcode = rfid.Data[0].Barcode;
                            dataDump.truck_type = Convert.ToInt32(truck_type);
                            dataDump.weight_type = Convert.ToInt32(weight_type);
                            dataDump.queue_status = 3;
                            string message_update = RFID.UpdateRFID(dataDump);

                            //Insert Data RFID Log

                            DataModel data_rfid = new DataModel()
                            {
                                dump_id = dump,
                                area_id = Setting.area_id,
                                crop_year = Setting.crop_year,
                                allergen = rfid.Data[0].Allergen,
                                truck_number = rfid.Data[0].TruckNumber,
                                farmer_name = rfid.Data[0].FarmerName,
                                barcode = rfid.Data[0].Barcode,
                                cane_type = Int32.Parse(rfid.Data[0].CaneType),
                                weight_type = Convert.ToInt32(weight_type),
                                truck_type = Convert.ToInt32(truck_type),
                                rfid = data_dump.rfid,
                                queue_status = 3,
                                rfid_lastdate = now
                            };

                            string message_insert = RFID.InsertRFIDLog(data_rfid);


                            #endregion API

                            #region Allergen
                            //Check Allergen
                            if (rfid.Data[0].Allergen.ToLower().Trim() == "yes")
                            {
                                //Message Box Custom
                                TextAllergen("Allergen", "ดัมพ์ " + dump + " ทะเบียน " + rfid.Data[0].TruckNumber, "พบสารก่อให้เกิดภูมิแพ้");
                            }

                            #endregion Allergen
                        }
                    }
                }
            }

            catch (OpcUaServiceException ex)
            {
                try
                {
                    string path = Directory.GetCurrentDirectory();
                    SoundPlayer dump_wave_file = new SoundPlayer();
                    dump_wave_file.SoundLocation = Path.Combine(path, $"voice\\noscan.wav");
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
                    ResultUpdateAlledModel dataUpdate = await API.UpdateAlled(setting.area_id.ToString(), setting.crop_year, rfid.Data[0].Barcode, alleD);

                    if (dataUpdate.Data[0].StatusDb != 0) // Send Complete
                    {
                        string loca = @"D:\log_alled.txt";
                        File.AppendAllText(loca, DateTime.Now + " Barcode " + rfid.Data[0].Barcode + " " + " Code " + dataUpdate.Data[0].StatusDb + " " + Environment.NewLine);
                    }
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
        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await OpcUaService.Instance.DisconnectAsync();
        }
    }
}
