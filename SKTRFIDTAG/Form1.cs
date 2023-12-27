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
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKTRFIDTAG
{
    public partial class Form1 : Form
    {
        int phase = 0;
        private IAccessory Accessory;
        private ITagLog TagLog;
        private ISetting Setting;
        List<TagLogModel> tags = new List<TagLogModel>();
        static List<Reader> Readers = new List<Reader>();
        static RfidTag SelectedTag = null;
        Reader readers = null;
        string tag_id = "";
        Reader SelectedReader = null;
        bool writer = false;
        public Form1(string _phase)
        {
            InitializeComponent();
            phase = Int32.Parse(_phase);
            Accessory = new AccessoryService();
            TagLog = new TagLogService(phase);
            Setting = new SettingService(phase);
            this.Text = "SKT RFID TAG PHASE " + phase;
        }

        private void txtSearchRFID_TextChanged(object sender, EventArgs e)
        {
            btnWrite.Enabled = false;
            txtTag.Text = "";
            tags = TagLog.GetTagLogByRFID(txtSearchRFID.Text);

            dataGridView1.Rows.Clear();
            for (int i = 0; i < tags.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                row.Height = 35;
                row.Cells[0].Value = (i + 1);
                row.Cells[1].Value = tags[i].tag;
                row.Cells[2].Value = tags[i].rfid;
                row.Cells[3].Value = tags[i].tag_date.ToString("dd/MM/yyyy HH:mm:ss");
                dataGridView1.Rows.Add(row);
            }
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("ต้องการยืนยันหรือไม่ ?", "SKT RFID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                writer = false;
                while (!writer)
                {
                    if (readers != null)
                    {
                        SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);
                        var tuple = await OpcUaService.Instance.ScanAsync(SelectedReader, 1, 1);
                        if (tuple.Item1.Status == "SUCCESS")
                        {
                            tag_id = tuple.Item1.Tags[0].IdentiferString;
                            SelectedTag = tuple.Item1.Tags[0];
                            string data_write = txtTag.Text;

                            byte[] data = Enumerable.Range(0, 12 * 2)
                                            .Where(x => x % 2 == 0)
                                            .Select(x => Convert.ToByte(data_write.Substring(x, 2), 16))
                                            .ToArray();


                            try
                            {
                                var result_write = await OpcUaService.Instance.WriteTagAsync(SelectedReader, SelectedTag, 0, data);
                                Thread.Sleep(1000);
                                if (result_write.Item2.IsGood)
                                {
                                    if (readers != null)
                                    {
                                        SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);
                                        string read_tag = "";
                                        try
                                        {
                                            var result_read = await OpcUaService.Instance.ReadTagAsync(SelectedReader, SelectedTag, 0, 13);
                                            if (result_read.Item2.IsGood)
                                            {
                                                read_tag = BitConverter.ToString(result_read.Item1).Replace("-", string.Empty);
                                                if (read_tag.Contains(txtTag.Text))
                                                {
                                                    writer = true;
                                                    MessageBox.Show("เขียนบัตร เรียบร้อย","SKT RFID");
                                                    btnWrite.Enabled = false;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error", "SKT RFID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        private async void btnRead_Click(object sender, EventArgs e)
        {
            if (readers != null)
            {
                SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);
                var tuple = await OpcUaService.Instance.ScanAsync(SelectedReader, true);
                if (tuple.Item1.Status == "SUCCESS")
                {
                    tag_id = tuple.Item1.Tags[0].IdentiferString;
                    SelectedTag = tuple.Item1.Tags[0];

                    string read_tag = "";
                    try
                    {
                        var result_read = await OpcUaService.Instance.ReadTagAsync(SelectedReader, SelectedTag, 0, 13);
                        if (result_read.Item2.IsGood)
                        {
                            read_tag = BitConverter.ToString(result_read.Item1).Replace("-", string.Empty);
                            txtTag.Text = read_tag;
                            DataModel data = Accessory.ReadDataRFIDCard(read_tag);
                            
                            txtRFID.Text = data.rfid;
                            txtTruck.Text = data.truck_number;
                            txtTypeTruck.Text = truckType(data.truck_type);
                            txtBarcode.Text = data.barcode;
                            txtTypeCane.Text = CaneType(data.cane_type);
                            txtTypeWeight.Text = weightType(data.weight_type);
                            txtQueue.Text = queueStatus(data.queue_status);
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (toolStripStatusConnect.Text == "Connected")
            {
                btnWrite.Enabled = true;               
            }
            if (e.RowIndex > -1)
            {
                string tag = tags[e.RowIndex].tag;
                DataModel data = Accessory.ReadDataRFIDCard(tag);

                txtRFID.Text = data.rfid;
                txtTruck.Text = data.truck_number;
                txtTypeTruck.Text = truckType(data.truck_type);
                txtBarcode.Text = data.barcode;
                txtTypeCane.Text = CaneType(data.cane_type);
                txtTypeWeight.Text = weightType(data.weight_type);
                txtQueue.Text = queueStatus(data.queue_status);
                txtTag.Text = tag.Substring(0, 23) + "0";
            }
        }
        private string CaneType(int n)
        {
            if (n == -1)
            {
                return "";
            }
            List<string> canes_type = new List<string>();
            canes_type.Add("สดท่อน");
            canes_type.Add("ไฟไหม้ท่อน");
            canes_type.Add("สดลำ");
            canes_type.Add("ไฟไหม้ลำ");

            return canes_type[n];
        }
        private string truckType(int n)
        {
            if (n == -1)
            {
                return "";
            }
            List<string> trucks_type = new List<string>();
            trucks_type.Add("");
            trucks_type.Add("รถเดี่ยว");
            trucks_type.Add("พ่วงแม่");
            trucks_type.Add("พ่วงลูก");
            return trucks_type[n];
        }
        private string weightType(int n)
        {
            List<string> weights_type = new List<string>();
            weights_type.Add("");
            weights_type.Add("ชั่งรวม");
            weights_type.Add("ชั่งแยก");
            return weights_type[n];
        }
        private string queueStatus(int n)
        {
            List<string> queues_status = new List<string>();
            queues_status.Add("");
            queues_status.Add("แจ้งคิวแล้ว");
            queues_status.Add("ชั่งเข้าแล้ว");
            queues_status.Add("ดัมพ์แล้ว");
            return queues_status[n];
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            SettingModel setting = Setting.GetSetting();
            try
            {
                bool connect =  OpcUaService.Instance.Connect(setting.ip2, 4840);
                if (connect)
                {
                    RefreshReaderListCommandExecute();
                    readers = Readers.Where(w => w.Ident == "Ident 3").FirstOrDefault();

                    if (readers != null)
                    {
                        toolStripStatusConnect.Text = "Connected";
                        btnRead.Enabled = true;
                    }
                    else
                    {
                        toolStripStatusConnect.Text = "Disconnect";
                    }
                }
            }
            catch
            {
                toolStripStatusConnect.Text = "Disconnect";
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
                Readers = Readers.OrderBy(o => o.Ident).ToList();
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
