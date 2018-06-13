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
using FlatlineClassLibrary;
using FlatlineDDNS;


namespace FlatlineDDNS
{
    public partial class Form_Configuration : Form
    {
        
        public Form_Configuration()
        {
            InitializeComponent();
        }

        //Brings you to the Google Domain's page. When more providers are added, this will check what provider is selected.
        private void label_InfoHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://support.google.com/domains/answer/6147083?hl=en"); //Go to site
        }

        //Set up combobox content on load.
        private void Form_Configuration_Load(object sender, EventArgs e)
        {
            ComboBoxRefresh(); //clears stuff and sets up combobox
            comboBox_ListOfDomains.SelectedIndex = 0; //what appears in the box on load
        }

        //When a new entry is selected in the combobox.
        private void comboBox_ListOfDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            //depending on what is in the combobox, program tells what the UI should be.
            if (comboBox_ListOfDomains.Text == "(Create a new domain)") 
            {
                label_EnterAName.Visible = true;
                textBox_EnterAName.Visible = true;
                button_RemoveSelectedDomain.Visible = false;
                button_SaveChangesToDomain.Text = "Save New Domain";
                ClearAll();
            }
            else
            {
                label_EnterAName.Visible = false;
                textBox_EnterAName.Visible = false;
                button_RemoveSelectedDomain.Visible = true;
                button_SaveChangesToDomain.Text = "Save Changes to Current Domain";

                //I did it this way to avoid keeping track of a global indexer variable. Combobox index will always be the same as the generic list's.
                textBox_EnterAName.Text = ReadConfig.ReadDomainSetting()[comboBox_ListOfDomains.SelectedIndex - 1].UserAssignedName;
                textBox_Username.Text = ReadConfig.ReadDomainSetting()[comboBox_ListOfDomains.SelectedIndex - 1].Username;
                textBox_Password.Text = ReadConfig.ReadDomainSetting()[comboBox_ListOfDomains.SelectedIndex - 1].Password;
                textBox_Domain.Text = ReadConfig.ReadDomainSetting()[comboBox_ListOfDomains.SelectedIndex - 1].Domain;
                if (ReadConfig.ReadDomainSetting()[comboBox_ListOfDomains.SelectedIndex - 1].Enabled == "1")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }

        //When an entry is updated or created
        private void button_SaveChangesToDomain_Click(object sender, EventArgs e)
        {           
            if (comboBox_ListOfDomains.Text == "(Create a new domain)") //exception handling stuff. User has to enter at least something into the fields.
            {
                if (textBox_Username.Text == "")
                {
                    MessageBox.Show("Please enter a Username.");
                    return;
                }
                if (textBox_Password.Text == "")
                {
                    MessageBox.Show("Please enter a Password.");
                    return;
                }
                if (textBox_Domain.Text == "")
                {
                    MessageBox.Show("Please enter a Domain.");
                    return;
                }
                if (textBox_EnterAName.Text == "")
                {
                    MessageBox.Show("Please enter a Name for this domain entry.");
                    return;
                }
                
                //Try to add a new domain into our configfile.xml.
                //Save result to bool.
                bool successfulSetting = WriteConfig.NewDomainSetting(textBox_EnterAName.Text, textBox_Username.Text, textBox_Password.Text, textBox_Domain.Text, comboBox_ListOfProviders.Text, (checkBox1.Checked ? 1 : 0).ToString());

                //If setting was written, refresh the combobox of domain settings and inform the user.
                if (successfulSetting == true)
                {
                    ComboBoxRefresh(); //Show the domain that was just added.
                    MessageBox.Show("Entry added and user settings updated."); //Notify user: Entry addition successful.
                    comboBox_ListOfDomains.SelectedIndex = 0; //Reset selection in combobox.
                }
                else //If it fails, inform the user no new domain setting was written.
                {
                    MessageBox.Show("A saved domain setting with that unique name already exists.\nPlease enter a different unique name."); //Notify user: Entry addition successful.
                }

                
            }
            else //Info is added to new place in generic list. 
            {
                //exception handling stuff. User has to enter at least something into the fields when editing an entry.
                if (textBox_Username.Text == "")
                {
                    MessageBox.Show("Please enter a Username");
                    return;
                }
                if (textBox_Password.Text == "")
                {
                    MessageBox.Show("Please enter a Password");
                    return;
                }
                if (textBox_Domain.Text == "")
                {
                    MessageBox.Show("Please enter a Domain");
                    return;
                }
                if (textBox_EnterAName.Text == "")
                {
                    MessageBox.Show("Please enter a Name for this domain entry");
                    return;
                }

                //Write the new setting to the configfile.xml. The checkbox is converted to a 1 or 0 based on the checked state. 1 for true. 0 for false.
                WriteConfig.UpdateDomainSetting(textBox_EnterAName.Text, textBox_Username.Text, textBox_Password.Text, textBox_Domain.Text, comboBox_ListOfProviders.Text, (checkBox1.Checked ? 1 : 0).ToString());

                MessageBox.Show("Entry has been updated."); //Notify user: Entry edit successful.
            }
        }

        //Resets all fields
        private void button_ResetAllInfo_Click(object sender, EventArgs e)
        {
            ClearAll(); //clears all fields.
        }

        //Removes an entry that is currently selected
        public void button_RemoveSelectedDomain_Click(object sender, EventArgs e)
        {
            if (comboBox_ListOfDomains.SelectedIndex == 0) //Don't allow user to delete the "Create new" option.
            {
                MessageBox.Show("Cannot remove this entry."); //Notify user: cannot delete "Create new."
                return; //exits
            }
            else
            {
                //Call method to remove the entry from the configfile.xml given the unique ID name.
                WriteConfig.RemoveDomainSetting(comboBox_ListOfDomains.GetItemText(comboBox_ListOfDomains.SelectedItem));

                ComboBoxRefresh(); //Reset combo box so deleted entry does not appear any longer.
                comboBox_ListOfDomains.SelectedIndex = 0; //Reset selection in combobox.
                
                MessageBox.Show("Domain removed and user settings updated."); //Notify user: domain removal successful.
            }

            
            
        }

        //PROGRAMMER METHODS
        //-------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Clears and adds new data into the list of domains combobox.
        /// </summary>
        private void ComboBoxRefresh()
        {
            comboBox_ListOfDomains.Items.Clear(); //Clear combox completely.
            comboBox_ListOfDomains.Items.Add("(Create a new domain)"); //Add back the default value at position 0;
            //Loop through list and at all entries available to the combobox.
            for (int i = 0; i < ReadConfig.ReadDomainSetting().Count; i++)
            {
                comboBox_ListOfDomains.Items.Add(ReadConfig.ReadDomainSetting()[i].UserAssignedName);
            }
        }

        /// <summary>
        /// Clears all user editable fields on the form, and sets the checkbox to default.
        /// </summary>
        private void ClearAll()
        {
            //Clears all fields on form.
            textBox_EnterAName.Clear();
            textBox_Domain.Clear();
            textBox_Username.Clear();
            textBox_Password.Clear();
            checkBox1.Checked = true;
        }

        //-------------------------------------------------------------------------------------------------------------------

    }
}
