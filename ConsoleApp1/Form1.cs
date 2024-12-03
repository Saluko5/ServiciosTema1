using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p;
            p = Process.Start("Notepad");
            Console.WriteLine("Name: {0}\nPID: {1}\nSubprocesses: {2}\nInit: {3}",
            p.ProcessName, p.Id, p.Threads.Count, p.StartTime);
            p.WaitForExit();
            Console.WriteLine("Aplication finished in date and time {0}", p.ExitTime);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
