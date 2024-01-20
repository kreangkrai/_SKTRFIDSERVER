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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKTRFIDCHECKHARDWAREPHASE
{
    public partial class Form1 : Form
    {
        CJ2Compolet cj2;
        
        private ISetting Setting;
        SettingModel setting;
        int phase = 0;
        public Form1()
        {
            InitializeComponent();
            phase = Int32.Parse(lblPhase.Text);
            Setting = new SettingService(phase);           
        }

        private void btnPLCCheck1_Click(object sender, EventArgs e)
        {
            cj2 = new CJ2Compolet();
            cj2.ConnectionType = ConnectionType.UCMM;
            cj2.UseRoutePath = false;
            cj2.PeerAddress = setting.ip_plc;
            cj2.LocalPort = 2;
            cj2.Active = true;

            lblPLCIP1.Text = setting.ip_plc;
            try
            {
                if (phase == 1)
                {
                    bool auto_d1 = (bool)cj2.ReadVariable("Call_D1");
                    btnPLC1.BackColor = Color.YellowGreen;
                }
                if (phase == 2)
                {
                    bool auto_d8 = (bool)cj2.ReadVariable("Call_D8");
                    btnPLC1.BackColor = Color.YellowGreen;
                }
            }
            catch
            {
                btnPLC1.BackColor = Color.Red;
            }

            if (cj2.IsConnected)
            {
                cj2.Active = false;
                cj2.Dispose();
            }
        }

       
        private async void btnRFIDCheck1_Click(object sender, EventArgs e)
        {
            List<Reader> Readers = new List<Reader>();
            lblRFIDIP1.Text = setting.ip1;
            try
            {
                if (await OpcUaService.Instance.ConnectAsync(setting.ip1, 4840))
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
                    catch
                    {
                        btnIdent0_1.BackColor = Color.Red;
                        btnIdent1_1.BackColor = Color.Red;
                        btnIdent2_1.BackColor = Color.Red;
                        btnIdent3_1.BackColor = Color.Red;
                    }
                }
                else
                {
                    btnIdent0_1.BackColor = Color.Red;
                    btnIdent1_1.BackColor = Color.Red;
                    btnIdent2_1.BackColor = Color.Red;
                    btnIdent3_1.BackColor = Color.Red;
                }

                bool IsIdent0 = Readers.Any(a => a.Ident == "Ident 0");
                bool IsIdent1 = Readers.Any(a => a.Ident == "Ident 1");
                bool IsIdent2 = Readers.Any(a => a.Ident == "Ident 2");
                bool IsIdent3 = Readers.Any(a => a.Ident == "Ident 3");

                if (IsIdent0)
                {
                    btnIdent0_1.BackColor = Color.YellowGreen;
                }
                else
                {
                    btnIdent0_1.BackColor = Color.Red;
                }

                if (IsIdent1)
                {
                    btnIdent1_1.BackColor = Color.YellowGreen;
                }
                else
                {
                    btnIdent1_1.BackColor = Color.Red;
                }

                if (IsIdent2)
                {
                    btnIdent2_1.BackColor = Color.YellowGreen;
                }
                else
                {
                    btnIdent2_1.BackColor = Color.Red;
                }

                if (IsIdent3)
                {
                    btnIdent3_1.BackColor = Color.YellowGreen;
                }
                else
                {
                    btnIdent3_1.BackColor = Color.Red;
                }
            }
            catch
            {
                btnIdent0_1.BackColor = Color.Red;
                btnIdent1_1.BackColor = Color.Red;
                btnIdent2_1.BackColor = Color.Red;
                btnIdent3_1.BackColor = Color.Red;
            }
        }

        private async void btnRFIDCheck2_Click(object sender, EventArgs e)
        {
            List<Reader> Readers = new List<Reader>();
            lblRFIDIP2.Text = setting.ip2;
            try
            {
                if (await OpcUaService.Instance.ConnectAsync(setting.ip2, 4840))
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
                    catch
                    {
                        btnIdent0_2.BackColor = Color.Red;
                        btnIdent1_2.BackColor = Color.Red;
                        btnIdent2_2.BackColor = Color.Red;
                        btnIdent3_2.BackColor = Color.Red;
                    }
                }
                else
                {
                    btnIdent0_2.BackColor = Color.Red;
                    btnIdent1_2.BackColor = Color.Red;
                    btnIdent2_2.BackColor = Color.Red;
                    btnIdent3_2.BackColor = Color.Red;
                }

                bool IsIdent0 = Readers.Any(a => a.Ident == "Ident 0");
                bool IsIdent1 = Readers.Any(a => a.Ident == "Ident 1");
                bool IsIdent2 = Readers.Any(a => a.Ident == "Ident 2");
                bool IsIdent3 = Readers.Any(a => a.Ident == "Ident 3");

                if (IsIdent0)
                {
                    btnIdent0_2.BackColor = Color.YellowGreen;
                }
                else
                {
                    btnIdent0_2.BackColor = Color.Red;
                }

                if (IsIdent1)
                {
                    btnIdent1_2.BackColor = Color.YellowGreen;
                }
                else
                {
                    btnIdent1_2.BackColor = Color.Red;
                }

                if (IsIdent2)
                {
                    btnIdent2_2.BackColor = Color.YellowGreen;
                }
                else
                {
                    btnIdent2_2.BackColor = Color.Red;
                }

                if (IsIdent3)
                {
                    btnIdent3_2.BackColor = Color.YellowGreen;
                }
                else
                {
                    btnIdent3_2.BackColor = Color.Red;
                }
            }
            catch
            {
                btnIdent0_2.BackColor = Color.Red;
                btnIdent1_2.BackColor = Color.Red;
                btnIdent2_2.BackColor = Color.Red;
                btnIdent3_2.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setting = Setting.GetSetting();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string bat = Path.Combine(path, "service");
            try
            {
                Process.Start(bat);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSysmac_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\OMRON\SYSMAC Gateway\bin\CIPCoreConsole.exe");
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            bool check_ip = checkInternet(lblIP.Text);
            if (check_ip)
            {
                btnIP.BackColor = Color.GreenYellow;
            }
            else
            {
                btnIP.BackColor = Color.Red;
            }
        }
        public bool checkInternet(string ip)
        {

            try
            {
                using (WebClient client = new WebClient())
                {
                    //PRODUCTION
                    using (client.OpenRead(ip))
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
