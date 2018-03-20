using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplicationPingTest
{
    public partial class Form1 : Form
    {
        delegate void SetListBoxCallback(String text);
        private List<String> adressen;
        public Form1()
        {
            InitializeComponent();
            fuelleliste();

        }

        private void fuelleliste()
        {
            adressen = new List<string>();
            StreamReader reader = new StreamReader(@"H:\Eigene Dateien\FI11\C#\WindowsFormsApplication1\WindowsFormsApplication1\Testadressen.txt", Encoding.UTF8);
            while (reader.EndOfStream == false)
            {
                adressen.Add(reader.ReadLine());
            }
            listBoxTestadressen.DataSource = adressen;
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(starteMethode);
            Thread th = new Thread(ts);
            th.Start();
        }

        private void starteMethode()
        { 
            try
            {
                Ping Sender = new Ping();
                for (int i = 0; i < adressen.Count; i++)
                {
                    PingReply Result = Sender.Send(adressen[i]);
                    if (Result.Status == IPStatus.Success)
                    {
                        SetListBoxOK(adressen[i]);
                    }
                    else
                    {
                        SetListBoxnichtOK(adressen[i]);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void SetListBoxnichtOK(string v)
        {
            if(listBoxnichtOk.InvokeRequired)
            {
                SetListBoxCallback del2 = new SetListBoxCallback(SetListBoxnichtOK);
                this.Invoke(del2, new object[] { v });
            }
            else
            {
                listBoxnichtOk.Items.Add(v);
            }
        }

        private void SetListBoxOK(string v)
        {
            if(listBoxOk.InvokeRequired)
            {
                SetListBoxCallback del = new SetListBoxCallback(SetListBoxOK);
                this.Invoke(del, new object[] { v });
            }
            else
            {
                listBoxOk.Items.Add(v);
            }
        }
    }
}
