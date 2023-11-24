using Newtonsoft.Json;
using SKTRFIDCOMMON.Interface;
using SKTRFIDCOMMON.Model;
using SKTRFIDCOMMON.Service;
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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKTRFIDCOMMON
{
    public partial class Form1 : Form
    {
        public int dump = 0;
        public string server = "";
        static List<Reader> Readers = new List<Reader>();
        static RfidTag SelectedTag = null;
        Reader readers = null;
        private IRFID RFID;
        public Form1(string _dump)
        {
            InitializeComponent();
            dump = Convert.ToInt32(_dump);
            server = "192.168.1.254";
            this.Text = server + " : " + dump;
            RFID = new RFIDService();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
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
                    #region Loop Scan
                    LoopScan:

                        #region SCAN
                        //Scan RFID
                        bool status_scan = false;
                        string tag_id = "";
                        while (status_scan == false)
                        {
                            try
                            {
                                var tuple = await OpcUaService.Instance.ScanAsync(SelectedReader, 1,1);
                                if (tuple.Item1.Status == "SUCCESS")
                                {
                                    tag_id = tuple.Item1.Tags[0].IdentiferString;
                                    SelectedTag = tuple.Item1.Tags[0];
                                    status_scan = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                string loca = @"D:\log.txt";
                                File.AppendAllText(loca, server + " " + dump + " " + DateTime.Now + " " + ex.Message + Environment.NewLine);
                                goto LoopScan;
                            }
                        }

                        #endregion SCAN

                        #region READ TAG
                        // Read Tag
                        bool status_read = false;
                        string read_tag = "";
                        while (status_read == false)
                        {
                            try
                            {
                                var result_read = await OpcUaService.Instance.ReadTagAsync(SelectedReader, SelectedTag, 0, 13);
                                if (result_read.Item2.IsGood)
                                {
                                    read_tag = BitConverter.ToString(result_read.Item1).Replace("-", string.Empty);
                                    status_read = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                string loca = @"D:\log.txt";
                                File.AppendAllText(loca, server + " " + dump + " " + DateTime.Now + " " + ex.Message + Environment.NewLine);
                                goto LoopScan;
                            }
                        }
                        #endregion READ TAG

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

                        if (read_tag.Length >= 12 * 2)
                        {
                            rfid_code = read_tag.Substring(0, 4);
                            license_plate1 = read_tag.Substring(4, 4);
                            license_plate2 = read_tag.Substring(8, 2);
                            license_plate3 = read_tag.Substring(10, 4);
                            truck_type = read_tag.Substring(14, 1);
                            weight_code = read_tag.Substring(15, 5);
                            cane_type = read_tag.Substring(20, 1);
                            weight_type = read_tag.Substring(21, 1);
                            queue_status = read_tag.Substring(22, 1);
                            dump_no = read_tag.Substring(23, 1);
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

                        #region WRITE TAG
                        //Write Tag
                        bool status_write = false;
                        queue_status = "3";
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

                        while (status_write == false)
                        {
                            try
                            {
                                var result_write = await OpcUaService.Instance.WriteTagAsync(SelectedReader, SelectedTag, 0, data);
                                if (result_write.Item2.IsGood)
                                {
                                    //Weite Data to text file
                                    string loca = @"D:\log.txt";
                                    File.AppendAllText(loca, server + " " + dump + " " + result_write.Item2.IsGood + " " + DateTime.Now + " " + tag_id + " " + data_write + Environment.NewLine);
                                    status_write = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                string loca = @"D:\log.txt";
                                File.AppendAllText(loca, server + " " + dump + " " + DateTime.Now + " " + ex.Message + Environment.NewLine);
                                goto LoopScan;
                            }
                        }

                        #endregion WRITE TAG

                        #region API
                        DataModel data_dump = new DataModel();
                        data_dump.dump_id = dump.ToString();
                        data_dump.area_id = 113;
                        data_dump.crop_year = "2565/66";
                        data_dump.rfid = int.Parse(rfid_code, System.Globalization.NumberStyles.HexNumber).ToString().PadLeft(6, '0');

                        // Run API Service
                        RFIDModel rfid = await CallAPI(data_dump);


                        //Save data truck 
                        if (rfid != null)
                        {
                            //Update status dump 
                            DataUpdateModel dataUpdate = await UpdateAPI(113, "2565/66", rfid.Data[0].Barcode, 1, dump, "ADD");
                            if (dataUpdate != null)
                            {
                                //Update Data To Database
                                DataModel dataDump = new DataModel();
                                dataDump.dump_id = dump.ToString();
                                dataDump.rfid = data_dump.rfid;
                                dataDump.truck_number = rfid.Data[0].TruckNumber;
                                dataDump.rfid_lastdate = DateTime.Now;
                                dataDump.cane_type = Int32.Parse(rfid.Data[0].CaneType);
                                dataDump.barcode = rfid.Data[0].Barcode;
                                dataDump.truck_type = Convert.ToInt32(truck_type);
                                dataDump.weight_type = Convert.ToInt32(weight_type);
                                dataDump.queue_status = 2;
                                string message = RFID.UpdateRFID(dataDump);
                            }
                            else
                            {
                                try
                                {
                                    SoundPlayer dump_wave_file = new SoundPlayer();
                                    dump_wave_file.SoundLocation = Path.Combine(path, $"voice\\noserver.wav");
                                    dump_wave_file.PlaySync();
                                }
                                catch
                                {

                                }
                                return;
                            }
                        }
                        else
                        {
                            try
                            {
                                SoundPlayer dump_wave_file = new SoundPlayer();
                                dump_wave_file.SoundLocation = Path.Combine(path, $"voice\\noserver.wav");
                                dump_wave_file.PlaySync();
                            }
                            catch
                            {

                            }
                            return;
                        }

                        #endregion API
                        // Speaker
                        Run(rfid, dump);
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
                    }
                    #endregion Loop Scan
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
        private async Task<DataUpdateModel> UpdateAPI(int areaid, string cropyear, string barcode, int phase, int dump, string type)
        {
            DataUpdateModel data = new DataUpdateModel();
            try
            {
                HttpClient client = new HttpClient();
                string url = $"http://thipskt.cristalla.co.th/jsonforandroidskt/insertDump?areaid={areaid}&cropyear={cropyear}&barcode={barcode}&phase={phase}&dump={dump}&type={type}";
                HttpResponseMessage response = await client.PostAsync(url, null);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<DataUpdateModel>(responseBody);
                }
                return data;
            }
            catch
            {
                return null;
            }
        }
        private async Task<RFIDModel> CallAPI(DataModel data)
        {
            RFIDModel rfid = new RFIDModel();
            try
            {
                HttpClient client = new HttpClient();
                string url = $"http://thipskt.cristalla.co.th/jsonforandroidskt/getRfidDump?areaid={data.area_id}&cropyear={data.crop_year}&card={data.rfid}";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    rfid = JsonConvert.DeserializeObject<RFIDModel>(responseBody);
                }
                return rfid;
            }
            catch
            {
                return null;
            }
        }
        private void Run(RFIDModel rfid, int dump)
        {
            string path = Directory.GetCurrentDirectory();
            if (rfid != null)
            {
                for (int j = 0; j < rfid.Data?[0].TruckNumber?.Length; j++)
                {
                    try
                    {
                        SoundPlayer my_wave_file = new SoundPlayer();
                        my_wave_file.SoundLocation = Path.Combine(path, $"voice\\{rfid.Data?[0].TruckNumber?[j]}.wav");
                        my_wave_file.PlaySync();
                    }
                    catch
                    {
                        continue;
                    }
                }

                try
                {
                    try
                    {
                        SoundPlayer save_wave_file = new SoundPlayer();
                        save_wave_file.SoundLocation = Path.Combine(path, $"voice\\save.wav");
                        save_wave_file.PlaySync();
                    }
                    catch
                    {

                    }
                }
                catch
                {
                    try
                    {
                        SoundPlayer my_wave_file = new SoundPlayer();
                        my_wave_file.SoundLocation = Path.Combine(path, $"voice\\noserver.wav");
                        my_wave_file.PlaySync();
                    }
                    catch
                    {

                    }
                }
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

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await OpcUaService.Instance.DisconnectAsync();
        }
    }
}
