using Newtonsoft.Json;
using SKTRFIDLIB.Model;
using SKTRFIDLIB.Service;
using SKTRFIDSERVER.Interface;
using SKTRFIDSERVER.Model;
using SKTRFIDSERVER.Properties;
using SKTRFIDSERVER.Service;
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

namespace SKTRFIDSERVER
{
    public partial class Form1 : Form
    {
        public int dump = 0;
        public string server = "";
        static List<Reader> Readers = new List<Reader>();
        static RfidTag SelectedTag = null;
        Reader readers = null;
        private IRFID RFID;
        public Form1(string _server, string _dump)
        {
            InitializeComponent();
            dump = Convert.ToInt32(_dump);
            server = _server;
            this.Text = server + " : " + dump;
            RFID = new RFIDService();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (await OpcUaService.Instance.ConnectAsync(server, 4840))
                {
                    string ident = "";
                    List<string> idents = new List<string>();
                    idents.Add("Ident 0");
                    idents.Add("Ident 1");
                    idents.Add("Ident 2");
                    idents.Add("Ident 3");
                    if (server == "192.168.1.253")
                    {
                        ident = idents[dump - 1];
                    }
                    if (server == "192.168.1.254")
                    {
                        ident = idents[dump - 5];
                    }

                    string path = Directory.GetCurrentDirectory();
                    RefreshReaderListCommandExecute();

                    
                    if (server == "192.168.1.253")
                    {
                        readers = Readers.Where(w => w.Ident == ident).FirstOrDefault();
                    }
                    if (server == "192.168.1.254")
                    {
                        readers = Readers.Where(w => w.Ident == ident).FirstOrDefault();
                    }

                    label1.Text = "DUMP " + dump;

                    if (readers != null)
                    {
                        Reader SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);

                        // Call Dump
                        try
                        {
                            SoundPlayer dump_wave_file = new SoundPlayer();
                            dump_wave_file.SoundLocation = Path.Combine(path, $"voice\\dump{dump}.wav");
                            dump_wave_file.PlaySync();
                        }
                        catch
                        {

                        }
                    #region Loop Scan
                    LoopScan:
                        //Scan RFID
                        bool status_scan = false;
                        string tag_id = "";
                        while (status_scan == false)
                        {
                            try
                            {
                                var tuple = await OpcUaService.Instance.ScanAsync(SelectedReader, true);
                                if (tuple.Item1.Status == "SUCCESS")
                                {
                                    tag_id = tuple.Item1.Tags[0].IdentiferString;
                                    SelectedTag = tuple.Item1.Tags[0];
                                    status_scan = true;
                                }
                            }
                            catch(Exception ex)
                            {
                                string loca = @"D:\log.txt";
                                File.AppendAllText(loca, server + " " + dump + " " + DateTime.Now + " " + ex.Message + Environment.NewLine);
                                goto LoopScan;
                            }
                        }

                        // Read Tag
                        bool status_read = false;
                        //RfidTag selectedTag = null;
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
                            catch(Exception ex)
                            {
                                string loca = @"D:\log.txt";
                                File.AppendAllText(loca, server + " " + dump + " " + DateTime.Now + " " + ex.Message + Environment.NewLine);
                                goto LoopScan;
                            }
                        }

                        //Write Tag
                        bool status_write = false;
                        string date_now = DateTime.Now.ToString("yyyyMMddHHmmss");
                        string data_write = "0000FFFEEE" + date_now + "00";
                        byte[] data = Enumerable.Range(0, 13 * 2)
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
                                    File.AppendAllText(loca, server + " " + dump + " " + result_write.Item2.IsGood + " " + DateTime.Now + " " + tag_id + " " + read_tag + Environment.NewLine);
                                    status_write = true;
                                }
                            }
                            catch(Exception ex)
                            {
                                string loca = @"D:\log.txt";
                                File.AppendAllText(loca, server + " " + dump + " " + DateTime.Now + " " + ex.Message + Environment.NewLine);
                                goto LoopScan;
                            }
                        }

                        DataModel data_dump = new DataModel();
                        if (dump == 1)
                        {
                            data_dump.dump_id = "1";
                            data_dump.area_id = 113;
                            data_dump.crop_year = "2565/66";
                            data_dump.rfid = "007086";
                        }
                        if (dump == 2)
                        {
                            data_dump.dump_id = "1";
                            data_dump.area_id = 113;
                            data_dump.crop_year = "2565/66";
                            data_dump.rfid = "007086";
                        }
                        if (dump == 3)
                        {
                            data_dump.dump_id = "1";
                            data_dump.area_id = 113;
                            data_dump.crop_year = "2565/66";
                            data_dump.rfid = "007086";
                        }
                        if (dump == 4)
                        {
                            data_dump.dump_id = "1";
                            data_dump.area_id = 113;
                            data_dump.crop_year = "2565/66";
                            data_dump.rfid = "007086";
                        }
                        if (dump == 5)
                        {
                            data_dump.dump_id = "5";
                            data_dump.area_id = 113;
                            data_dump.crop_year = "2565/66";
                            data_dump.rfid = "006708";
                        }
                        if (dump == 6)
                        {
                            data_dump.dump_id = "6";
                            data_dump.area_id = 113;
                            data_dump.crop_year = "2565/66";
                            data_dump.rfid = "006648";
                        }
                        if (dump == 7)
                        {
                            data_dump.dump_id = "1";
                            data_dump.area_id = 113;
                            data_dump.crop_year = "2565/66";
                            data_dump.rfid = "007086";
                        }

                        // Run API Service
                        RFIDModel rfid = await CallAPI(data_dump);

                       
                        //Save data truck 
                        if (rfid != null)
                        {
                            //Update status dump 
                            DataUpdateModel dataUpdate = await UpdateAPI(113, "2565/66", rfid.Data[0].Barcode, 1, dump, "ADD");
                            if (dataUpdate != null)
                            {
                                //Update Data to Database
                                DataModel dataDump = new DataModel();
                                dataDump.dump_id = dump.ToString();
                                dataDump.rfid = data_dump.rfid;
                                dataDump.truck_number = rfid.Data[0].TruckNumber;
                                dataDump.rfid_lastdate = DateTime.Now;
                                dataDump.cane_type = Int32.Parse(rfid.Data[0].CaneType);
                                dataDump.barcode = rfid.Data[0].Barcode;
                                dataDump.truck_type = 0;
                                dataDump.weight_type = 0;
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

                //Update Data to Database
                DataModel dataDump = new DataModel();
                dataDump.dump_id = dump.ToString();
                dataDump.truck_number = "";
                dataDump.rfid_lastdate = DateTime.Now;
                dataDump.cane_type = 0;
                dataDump.barcode = "";
                dataDump.truck_type = 0;
                dataDump.weight_type = 0;
                dataDump.queue_status = 2;
                string message = RFID.UpdateRFID(dataDump);
            }
            finally
            {
                OpcUaService.Instance.Disconnect();
                this.Close();
            }
        }
        private async Task<DataUpdateModel> UpdateAPI(int areaid,string cropyear, string barcode,int phase,int dump, string type)
        {
            DataUpdateModel data = new DataUpdateModel();
            try
            {
                HttpClient client = new HttpClient();
                string url = $"http://thipskt.cristalla.co.th/jsonforandroidskt/insertDump?areaid={areaid}&cropyear={cropyear}&barcode={barcode}&phase={phase}&dump={dump}&type={type}";
                HttpResponseMessage response = await client.PostAsync(url,null);
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
