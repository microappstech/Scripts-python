using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace mp4_to__text
{
    public partial class BloSite : Form
    {
        public BloSite()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctypes.windll.shell32.ShellExecuteW(None, "runas", sys.executable, " ".join(sys.argv), None, 1)
            string file = @"C:/Windows/System32/drivers/etc/hosts";
            string url = textBox1.Text;

            StreamWriter fs = new StreamWriter(file);
            fs.WriteLine(url);
                }
    }
}
