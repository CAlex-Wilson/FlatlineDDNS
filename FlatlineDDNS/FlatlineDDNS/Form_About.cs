using Microsoft.Win32;
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

namespace FlatlineDDNS
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        //Google support link
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://support.google.com/domains/answer/6147083?hl=en"); //Go to site
        }

        //Faulty DNS link
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sourceforge.net/projects/faultydns/"); //Go to site
        }

        //CodyWilsonDesigns.com link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://codywilsondesigns.com"); //Go to site
        }
    }
}
