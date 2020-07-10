using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGOSoftwareBypass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Process proce = new Process();
            ProcessStartInfo info =
            new ProcessStartInfo(@"bin\emb.exe");
            info.UseShellExecute = true;
            info.Verb = "runas";
            proce.StartInfo = info;
           
                proce.Start();
                Console.WriteLine("Process Started");
                Thread.Sleep(1000);
            toolStripStatusLabel1.Text = "Bypassed";
        }

   
    }
}
