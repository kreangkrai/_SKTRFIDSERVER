﻿using SKTRFIDLIB.Model;
using SKTRFIDLIB.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTREADWRITE
{
    public partial class Form1 : Form
    {
        static List<Reader> Readers = new List<Reader>();
        static RfidTag SelectedTag = null;
        Reader readers = null;
        string tag_id = "";
        Reader SelectedReader = null;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (readers != null)
            {
                SelectedReader = new Reader(readers.NodeId, readers.Ident, readers.Type, readers.Name);
                var tuple = await OpcUaService.Instance.ScanAsync(SelectedReader, 1,1);
                if (tuple.Item1.Status == "SUCCESS")
                {
                    tag_id = tuple.Item1.Tags[0].IdentiferString;
                    SelectedTag = tuple.Item1.Tags[0];
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (await OpcUaService.Instance.ConnectAsync("192.168.1.253", 4840))
            {
                RefreshReaderListCommandExecute();
                readers = Readers.Where(w => w.Ident == "Ident 0").FirstOrDefault();
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
        private async void button2_Click(object sender, EventArgs e)
        {
            string read_tag = "";
            try
            {
                var result_read = await OpcUaService.Instance.ReadTagAsync(SelectedReader, SelectedTag, 0, 13);
                if (result_read.Item2.IsGood)
                {
                    read_tag = BitConverter.ToString(result_read.Item1).Replace("-", string.Empty);
                    textBox1.Text = read_tag;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string data_write = textBox2.Text;

            byte[] data = Enumerable.Range(0, 12 * 2)
                            .Where(x => x % 2 == 0)
                            .Select(x => Convert.ToByte(data_write.Substring(x, 2), 16))
                            .ToArray();


            try
            {
                var result_write = await OpcUaService.Instance.WriteTagAsync(SelectedReader, SelectedTag, 0, data);
                if (result_write.Item2.IsGood)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
