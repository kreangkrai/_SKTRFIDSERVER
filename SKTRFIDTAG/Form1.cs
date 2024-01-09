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
        private ISetting Setting;
        private ICodeType CodeType;
        static List<Reader> Readers = new List<Reader>();
        static RfidTag SelectedTag = null;
        Reader readers = null;
        string tag_id = "";
        Reader SelectedReader = null;
        bool writer = false;
        string tag_data = string.Empty;
        public Form1(string _phase)
        {
            InitializeComponent();
            phase = Int32.Parse(_phase);
            Setting = new SettingService(phase);
            CodeType = new CodeTypeService();
            Accessory = new AccessoryService();
            this.Text = "SKT RFID TAG PHASE " + phase;
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
                        var tuple = await OpcUaService.Instance.ScanAsync(SelectedReader, true);
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
                                    writer = true;
                                    MessageBox.Show("เขียนบัตร เรียบร้อย", "SKT RFID");
                                    btnWrite.Enabled = false;
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

                    try
                    {
                        var result_read = await OpcUaService.Instance.ReadTagAsync(SelectedReader, SelectedTag, 0, 13);
                        if (result_read.Item2.IsGood)
                        {
                            tag_data = BitConverter.ToString(result_read.Item1).Replace("-", string.Empty);
                            txtTag.Text = tag_data;
                            DataModel data = Accessory.ReadDataRFIDCard(tag_data);
                            
                            txtRFID.Text = data.rfid;
                            txtTruck.Text = data.truck_number;
                            txtTypeTruck.Text = CodeType.truckType(data.truck_type);
                            txtBarcode.Text = data.barcode;
                            txtTypeCane.Text = CodeType.CaneType(data.cane_type);
                            txtTypeWeight.Text = CodeType.weightType(data.weight_type);
                            txtQueue.Text = CodeType.queueStatus(data.queue_status);

                            txtRFID.Enabled = true;
                        }
                        else
                        {
                            txtRFID.Enabled = false;
                            MessageBox.Show("Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        txtRFID.Enabled = false;
                        MessageBox.Show(ex.Message);
                    }
                }
            }
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

        private void txtRFID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            if (txtRFID.TextLength >= 6)
            {
                var tag_stringBuilder = new StringBuilder(tag_data);
                tag_stringBuilder.Remove(0, 4);
                tag_stringBuilder.Insert(0, Int32.Parse(txtRFID.Text).ToString("x").ToUpper().PadLeft(4,'0'));
                txtTag.Text = tag_stringBuilder.ToString();
                btnWrite.Enabled = true;
            }
            else
            {
                btnWrite.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRFID.Text = "";
            txtBarcode.Text = "";
            txtQueue.Text = "";
            txtTag.Text = "";
            txtTruck.Text = "";
            txtTypeCane.Text = "";
            txtTypeTruck.Text = "";
            txtTypeWeight.Text = "";
        }
    }
}
