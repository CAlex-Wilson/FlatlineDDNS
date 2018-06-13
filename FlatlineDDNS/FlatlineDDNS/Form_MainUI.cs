using FlatlineDDNS.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Configuration;
using FlatlineClassLibrary;

//CREDITS AND ACKNOWLEDGEMENTS//
//-----------------------------------------------------------------------------//

//December 13, 2017 REVISED June 12, 2018
//Programmed and Designed: Cody Wilson.
//QA Tester and Associate: Chad Falatic.

//Based on FaultyDNS by shaneburk89.
//View FaultyDNS here: https://sourceforge.net/projects/faultydns/

//My website: http://codywilsondesigns.com

//-----------------------------------------------------------------------------//


namespace FlatlineDDNS
{
    public partial class Form_MainUI : Form
    {

        public Form_MainUI()
        {
            InitializeComponent();
        }

        //What occurs on start.
        private void Form_MainUI_Load(object sender, EventArgs e)
        {
            //FIRST RUN. If the user has never used the program before, it opens the configuration form for setup.//
            ////////////////////////////////////////////////////////////////////////////////////////////           
            if (File.Exists("configfile.xml") == false) //If program has not been run before, there will be no configfile.xml.
            { 
                //Open the config setup form.
                Form_FirstRunConfig first_run = new Form_FirstRunConfig();
                first_run.ShowDialog();

                //Starts timer for periodic checks.
                timer_NextCheck.Enabled = true;
            }
            else
            {
                //Starts timer for periodic checks.
                timer_NextCheck.Enabled = true;
                //Check runs on start to get values needed.
                TestIp(false);
            }           
        }

        //Display the Config Form.
        private void button_Configuration_Click(object sender, EventArgs e)
        {
            //Show the config form
            Form_Configuration config = new Form_Configuration();

            //Create form.closing event here. When the configuration form closes, it will update the
            //listbox with any modified information.
            config.FormClosing += new FormClosingEventHandler(this.Form_Configuration_FormClosing);
            config.ShowDialog();
        }
        private void Form_Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Use this custom event to update the MainUI form with any changes made via the configuration form.
            ListBoxRefresh();
        }

        //Display the About Form.
        static public Form_About about = new Form_About();
        private void button_About_Click(object sender, EventArgs e)
        {
            if (about.Visible == true)
            {
                MessageBox.Show("The About Page is already open."); //If form is open, do not launch it again.
                return;
            }
            else
            {
                // Show the about form
                about = new Form_About();
                about.Show();
            }
        }

        //Force tests the IP.
        private void button_ForceRefresh_Click(object sender, EventArgs e)
        {
            listBox_ListOfUsersDomains.Items.Clear(); //Clear old listbox info.
            TestIp(true); //Test the ip for changes.
        }

        //Timer for next Check.
        private void timer_NextCheck_Tick(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(label_NextIPCheck.Text) - 1; //Get label number.
            label_NextIPCheck.Text = num.ToString(); //Update the label for every second ticked.
            //Test IP is timer reaches the 0 mark.
            if (num == 0)
            {
                label_NextIPCheck.Text = 600.ToString();
                TestIp(false);
            }
        }

        //Override the form sizing so minimize sends app to system tray.
        private void Form_MainUI_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyicon.Visible = true;
                mynotifyicon.ShowBalloonTip(500);
                //mynotifyicon.Icon = Resources.iconGreenNew;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                mynotifyicon.Visible = false;
            }
        }

        //Double click on system tray icon to bring it back.
        private void mynotifyicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Move from tray to taskbar
            this.Show();
            //Draws window on screen instead of its minimized state
            Invoke(new Action(() => { this.WindowState = FormWindowState.Normal; }));
        }

        //PROGRAMMER METHODS
        //-------------------------------------------------------------------------------------------------------------------        
        /// <summary>
        /// Method for refreshing the listbox of current domains. Does not run a DDNS update.
        /// </summary>
        private void ListBoxRefresh()
        {
            //Clear out any prior data from the listbox.
            listBox_ListOfUsersDomains.Items.Clear();

            //Loop through all domain settings within the configfile.xml.
            for (int i = 0; i < ReadConfig.ReadDomainSetting().Count; i++)
            {
                //If the setting is enabled, display it as such --- and vice versa.
                if (ReadConfig.ReadDomainSetting()[i].Enabled == "1")
                {
                    listBox_ListOfUsersDomains.Items.Add(" (On*) " + ReadConfig.ReadDomainSetting()[i].UserAssignedName);
                }
                else
                {
                    listBox_ListOfUsersDomains.Items.Add(" (Off) " + ReadConfig.ReadDomainSetting()[i].UserAssignedName);
                }
            }
        }

        /// <summary>
        /// Method for testing whether the IP resolve worked or not.
        /// </summary>
        /// <param name="forceRefresh"></param>
        private void TestIp(bool forceRefresh = false)
        {
            ListBoxRefresh();
            string ip = Get_Client_IP(); //grabs user's current ip.

            if ((ip != label_UserIP.Text) || (forceRefresh == true)) //should be good now. If there are issues, it is here!
            {
                label_UserIP.Text = ip; //whatever the user's ip is now shows in label.
                for (int i = 0; i < listBox_ListOfUsersDomains.Items.Count; i++) //Loop though listbox console.
                {
                    if (ReadConfig.ReadDomainSetting()[i].Enabled == "1") //Only submit domain if it is enabled.
                    {
                        label_UpdateResponse.Text = Update_GoogleDDNS(ReadConfig.ReadDomainSetting()[i].Username, ReadConfig.ReadDomainSetting()[i].Password, ReadConfig.ReadDomainSetting()[i].Domain, ip); //Submit domain info.
                        listBox_ListOfUsersDomains.Items[i] = listBox_ListOfUsersDomains.Items[i].ToString() + " --> Last Check: " + label_UpdateResponse.Text; //Display info for each domain in the listbox console.
                        //backgroundWorker1.ReportProgress(i);
                    }
                }

                this.label_UpdateResponse.Text = "All Succeeded."; //default if there are no issues with any domains. STATUS BAR TEXT.
                label_UpdateResponse.BackColor = System.Drawing.Color.MediumSpringGreen; //default if there are no issues with any domains. STATUS BAR COLOR.
                this.Icon = Resources.iconGreenNew; //default if there are no issues with any domains. FORM ICON COLOR.
                mynotifyicon.Icon = Resources.iconGreenNew; //default if there are no issues with any domains. SYSTEM TRAY ICON COLOR.

                for (int i = 0; i < listBox_ListOfUsersDomains.Items.Count; i++) //Loop through each item in listbox.
                {
                    if ((listBox_ListOfUsersDomains.Items[i].ToString().Contains("nochg")) || (listBox_ListOfUsersDomains.Items[i].ToString().Contains("good"))) //If the entries ! contain the succeed codes.
                    {
                        //Do nothing for now.
                    }
                    else
                    {
                        label_UpdateResponse.Text = "At least one update failed. Check the console."; //Show that there was an error
                        label_UpdateResponse.BackColor = System.Drawing.Color.Red;
                        mynotifyicon.Icon = Resources.iconRedNew;
                        mynotifyicon.Text = "Update Failed - Flatline DDNS";
                        this.Icon = Resources.iconRedNew;

                        break; //Exit loop.
                    }
                }
                label_LastDNSSync.Text = DateTime.Now.ToString(); //update the last sync time.
            }
            label_LastIPCheck.Text = DateTime.Now.ToString(); //update the last ip check time.
        }

        /// <summary>
        /// Grabs user's current IP address. Checks two sites and uses REGEX to get proper format.
        /// </summary>
        /// <returns></returns>
        private string Get_Client_IP()
        {
            string currentIpAddress;
            try
            {
                //Get public IP of client. (Ipv4).
                string test1 = "";
                test1 = new WebClient().DownloadString("http://icanhazip.com/");
                currentIpAddress = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Matches(test1)[0].ToString(); //Regex to get just the IP.
            }
            catch
            {
                try
                {
                    string test2 = "";
                    test2 = new WebClient().DownloadString("http://checkip.dyndns.org/");
                    currentIpAddress = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Matches(test2)[0].ToString();
                }
                catch
                {
                    try
                    {
                        //This site is way slower than checkip.dyndns.org. Only use this as a last resort.
                        string test3 = "";
                        test3 = new WebClient().DownloadString("http://faultyserver.com/ipv4/");
                        currentIpAddress = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Matches(test3)[0].ToString();
                    }
                    catch
                    {
                        currentIpAddress = "FAILED CHECK"; //This will likely occur if device is offline.
                    }
                }
            }
            return currentIpAddress; //Return the address retrieved from site used.
        }

        /// <summary>
        /// //GOOGLE DOMAINS SUPPORT: Resolves DDNS Info For Google Domains. API info found here: https://support.google.com/domains/answer/6147083?hl=en
        /// </summary>
        /// <param name="username">The clients Google Domains username.</param>
        /// <param name="password">The clients Google Domains password.</param>
        /// <param name="hostname">The clients website hostname.</param>
        /// <param name="ip">The clients pubic facing IP address.</param>
        /// <returns></returns>
        private string Update_GoogleDDNS(string username, string password, string hostname, string ip)
        {
            string response; //What the conclusion of the test is.
            try
            {
                using (WebClient client = new WebClient()) //New web client.
                {
                    client.Headers.Add("Host", "domains.google.com"); //gets google domains.
                    client.Credentials = new NetworkCredential(username, password); //signs into domains using given Username and Password.
                    client.Headers.Add("User-Agent", "FlatlineDNS"); //Credentials for request authorization.
                    NameValueCollection dataUserInfo = new NameValueCollection(); //declare collection.
                    dataUserInfo.Add("myip", ip); //add user's ip to collection.
                    dataUserInfo.Add("hostname", hostname); //add user's hostname to collection.
                    byte[] bytes = client.UploadValues("https://domains.google.com/nic/update", "POST", dataUserInfo); //convert to bytes for sending.
                    response = Encoding.UTF8.GetString(bytes); //RETURNING REQUEST.                                     
                }
            }
            catch
            {
                response = "FAILED UPDATE"; //If it cannot even submit request at all.
            }
            return response; //Return what is determined.
        }

        //-------------------------------------------------------------------------------------------------------------------
    }
}
