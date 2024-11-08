using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestApp_Para
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Glob.temp;

            Process[] ps = Process.GetProcesses();
            foreach (Process p in ps)
            {
                string info = "";
                try
                {
                    //info = p.Id + "  " + p.ProcessName + "  " + p.MainWindowTitle + "  " + p.StartTime;
                    info = p.ProcessName;
                }
                catch (Exception ex)
                {
                    info = ex.Message;
                }
                //Console.WriteLine(info);
                if(!listBox1.Items.Contains(info))
                {
                    listBox1.Items.Add(info);
                }
            }
        }
    }

    public static class Glob
    {
        public static string temp;
    }
}
