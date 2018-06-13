using FlatlineClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlatlineDDNS
{
    public partial class Form_FirstRunConfig : Form
    {
        public Form_FirstRunConfig()
        {
            InitializeComponent();
        }

        //Show prior config help form.
        static public Form_PriorConfigHelp help = new Form_PriorConfigHelp();
        private void button_Help_Click(object sender, EventArgs e)
        {
            if (help.Visible == true)
            {
                MessageBox.Show("The Prior Config Help Page is already open.");
                return;
            }
            else
            {
                //Show the config form
                help = new Form_PriorConfigHelp();
                help.Show();
            }
        }

        public string directoryPath= ""; //Path of directory with the file as well.
        public string directoryPathNoFile = ""; //Path of just the directory, no file.
        private void button_LoadPriorConfigFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); //Open dialog to grab config file.
            dialog.Filter = "XML config files (*.xml)|*.xml";
            dialog.Title = "Please select a configfile.xml file.";

            if ((dialog.ShowDialog() == DialogResult.OK) && (Path.GetExtension(dialog.FileName) == ".xml"))
            {
                directoryPath = dialog.FileName;
                directoryPathNoFile = (Path.GetDirectoryName(dialog.FileName));

                label_CurrentFileName.Text = dialog.SafeFileName; //Show user the file they loaded in.
            }
        }

        private void button_LaunchPriorConfig_Click(object sender, EventArgs e)
        {
            if ((directoryPath != "") || (label_CurrentFileName.Text != "No file currently loaded..."))
            {
                WriteConfig.CreateXMLConfigFile();

                //Make sure the files can be accessed despite the current privileges.
                File.SetAttributes("configfile.xml", FileAttributes.Normal);
                File.SetAttributes(directoryPath, FileAttributes.Normal);
                File.SetAttributes(directoryPathNoFile, FileAttributes.Normal);

                MessageBox.Show(directoryPath);
                File.Copy(directoryPath, "configfile.xml", true); //Copy the file the user gave and use it to overwrite the config made by the program in the root location.

                MessageBox.Show("Config import successful. Re-launch in order for changes to take effect.\n\nEnjoy,\n-The Flatline DDNS Team"); //Welcome the user.
                Application.Exit(); //Close app so changes can take effect.
            }
            else
            {
                MessageBox.Show("No config file has been loaded in.");
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Force app to quit. Ensures the launch does not count as the first-run.
        }

        private void button_LaunchNewConfig_Click(object sender, EventArgs e)
        {
            WriteConfig.CreateXMLConfigFile();
            this.Close(); //Close form and continue to app.
        }

    }
}
