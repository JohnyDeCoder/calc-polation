using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace calc_polation_2022
{
    public partial class CALPO_About : Form
    {
        public CALPO_About()
        {
            InitializeComponent();
        }

        private void CALPO_About_Load(object sender, EventArgs e)
        {

        }

        private void link_programmer_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_programmer_1.LinkVisited = true;

            // ProcessStartInfo.UseShellExecute Property
            using (Process compiler = new Process())
            {
                compiler.StartInfo.FileName = "https://github.com/JohnyDeCoder";
                //compiler.StartInfo.Arguments = "/r:System.dll /out:sample.exe stdstr.cs";
                compiler.StartInfo.UseShellExecute = true;
                //compiler.StartInfo.RedirectStandardOutput = true;
                compiler.Start();
            }
        }

        private void link_programmer_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_programmer_2.LinkVisited = true;

            // ProcessStartInfo.UseShellExecute Property
            using (Process compiler = new Process())
            {
                compiler.StartInfo.FileName = "https://github.com/BrandonMoran11";
                //compiler.StartInfo.Arguments = "/r:System.dll /out:sample.exe stdstr.cs";
                compiler.StartInfo.UseShellExecute = true;
                //compiler.StartInfo.RedirectStandardOutput = true;
                compiler.Start();
            }
        }
    }
}
