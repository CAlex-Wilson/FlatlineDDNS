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
    public partial class Form_PriorConfigHelp : Form
    {
        public Form_PriorConfigHelp()
        {
            InitializeComponent();
        }

        //Close the form on button click.
        private void button_TakeMeThere_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
