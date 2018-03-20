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

namespace WindowsFormsApplicationPingTestmitThread
{
    public partial class Form1 : Form
    {
        delegate void SetListBoxCallback(String text);

        public Form1()
        {
            InitializeComponent();

        }

        private void starteMethode()
        {
            for(int i =1; i <10; i++)
            {
                //listBoxOk.Items.Add("Test");
                SetListBoxText("Test");
            }
        }

        private void SetListBoxText(string v)
        {
            if(listBoxOk.InvokeRequired)
            {
                SetListBoxCallback del = new SetListBoxCallback(SetListBoxText);
                this.Invoke(del, new object[] { Text });
            }
            else
            {
                listBoxOk.Items.Add("Test");
            }
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(starteMethode);
            Thread th = new Thread(ts);
            th.Start();
        }
    }
}
