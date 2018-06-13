namespace FlatlineDDNS
{
    partial class Form_MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_NextIPCheck = new System.Windows.Forms.Label();
            this.label_LastDNSSync = new System.Windows.Forms.Label();
            this.label_LastIPCheck = new System.Windows.Forms.Label();
            this.label_UpdateResponse = new System.Windows.Forms.Label();
            this.label_UserIP = new System.Windows.Forms.Label();
            this.button_ForceRefresh = new System.Windows.Forms.Button();
            this.button_Configuration = new System.Windows.Forms.Button();
            this.listBox_ListOfUsersDomains = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_About = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer_NextCheck = new System.Windows.Forms.Timer(this.components);
            this.mynotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Public IP:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last IP Check:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last DNS Sync:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Next IP Check:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_NextIPCheck
            // 
            this.label_NextIPCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NextIPCheck.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NextIPCheck.Location = new System.Drawing.Point(12, 250);
            this.label_NextIPCheck.Name = "label_NextIPCheck";
            this.label_NextIPCheck.Size = new System.Drawing.Size(344, 18);
            this.label_NextIPCheck.TabIndex = 9;
            this.label_NextIPCheck.Text = "600";
            this.label_NextIPCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_LastDNSSync
            // 
            this.label_LastDNSSync.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LastDNSSync.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastDNSSync.Location = new System.Drawing.Point(12, 204);
            this.label_LastDNSSync.Name = "label_LastDNSSync";
            this.label_LastDNSSync.Size = new System.Drawing.Size(344, 18);
            this.label_LastDNSSync.TabIndex = 8;
            this.label_LastDNSSync.Text = "/";
            this.label_LastDNSSync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_LastIPCheck
            // 
            this.label_LastIPCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LastIPCheck.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastIPCheck.Location = new System.Drawing.Point(12, 158);
            this.label_LastIPCheck.Name = "label_LastIPCheck";
            this.label_LastIPCheck.Size = new System.Drawing.Size(344, 18);
            this.label_LastIPCheck.TabIndex = 7;
            this.label_LastIPCheck.Text = "/";
            this.label_LastIPCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_UpdateResponse
            // 
            this.label_UpdateResponse.BackColor = System.Drawing.Color.Gold;
            this.label_UpdateResponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_UpdateResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdateResponse.Location = new System.Drawing.Point(0, 611);
            this.label_UpdateResponse.Name = "label_UpdateResponse";
            this.label_UpdateResponse.Size = new System.Drawing.Size(368, 28);
            this.label_UpdateResponse.TabIndex = 6;
            this.label_UpdateResponse.Text = "No Update has occured yet.";
            this.label_UpdateResponse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_UserIP
            // 
            this.label_UserIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_UserIP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserIP.Location = new System.Drawing.Point(12, 112);
            this.label_UserIP.Name = "label_UserIP";
            this.label_UserIP.Size = new System.Drawing.Size(344, 18);
            this.label_UserIP.TabIndex = 5;
            this.label_UserIP.Text = "/";
            this.label_UserIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ForceRefresh
            // 
            this.button_ForceRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ForceRefresh.BackColor = System.Drawing.Color.LightGray;
            this.button_ForceRefresh.FlatAppearance.BorderSize = 0;
            this.button_ForceRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ForceRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ForceRefresh.Location = new System.Drawing.Point(90, 12);
            this.button_ForceRefresh.Name = "button_ForceRefresh";
            this.button_ForceRefresh.Size = new System.Drawing.Size(110, 35);
            this.button_ForceRefresh.TabIndex = 1;
            this.button_ForceRefresh.Text = "Force Update";
            this.button_ForceRefresh.UseVisualStyleBackColor = false;
            this.button_ForceRefresh.Click += new System.EventHandler(this.button_ForceRefresh_Click);
            // 
            // button_Configuration
            // 
            this.button_Configuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Configuration.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_Configuration.FlatAppearance.BorderSize = 0;
            this.button_Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Configuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Configuration.Location = new System.Drawing.Point(206, 12);
            this.button_Configuration.Name = "button_Configuration";
            this.button_Configuration.Size = new System.Drawing.Size(150, 35);
            this.button_Configuration.TabIndex = 2;
            this.button_Configuration.Text = "Configuration";
            this.button_Configuration.UseVisualStyleBackColor = false;
            this.button_Configuration.Click += new System.EventHandler(this.button_Configuration_Click);
            // 
            // listBox_ListOfUsersDomains
            // 
            this.listBox_ListOfUsersDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_ListOfUsersDomains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_ListOfUsersDomains.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_ListOfUsersDomains.FormattingEnabled = true;
            this.listBox_ListOfUsersDomains.HorizontalScrollbar = true;
            this.listBox_ListOfUsersDomains.Location = new System.Drawing.Point(12, 309);
            this.listBox_ListOfUsersDomains.Name = "listBox_ListOfUsersDomains";
            this.listBox_ListOfUsersDomains.ScrollAlwaysVisible = true;
            this.listBox_ListOfUsersDomains.Size = new System.Drawing.Size(344, 286);
            this.listBox_ListOfUsersDomains.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(12, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(344, 28);
            this.label11.TabIndex = 13;
            this.label11.Text = "Current List of Your Domains:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button_About
            // 
            this.button_About.BackColor = System.Drawing.Color.LightGray;
            this.button_About.FlatAppearance.BorderSize = 0;
            this.button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_About.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_About.Location = new System.Drawing.Point(12, 12);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(72, 35);
            this.button_About.TabIndex = 0;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = false;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dynamic To Static Hub";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_NextCheck
            // 
            this.timer_NextCheck.Interval = 1000;
            this.timer_NextCheck.Tick += new System.EventHandler(this.timer_NextCheck_Tick);
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mynotifyicon.BalloonTipText = "Flatline DDNS moved to  your system  tray.";
            this.mynotifyicon.BalloonTipTitle = "Attention:";
            this.mynotifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyicon.Icon")));
            this.mynotifyicon.Text = "All Succeeded - Flatline DDNS";
            this.mynotifyicon.Visible = true;
            this.mynotifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mynotifyicon_MouseDoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // Form_MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_UpdateResponse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_Configuration);
            this.Controls.Add(this.button_ForceRefresh);
            this.Controls.Add(this.label_NextIPCheck);
            this.Controls.Add(this.label_LastDNSSync);
            this.Controls.Add(this.label_LastIPCheck);
            this.Controls.Add(this.label_UserIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_ListOfUsersDomains);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(280, 39);
            this.Name = "Form_MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flatline DDNS";
            this.Load += new System.EventHandler(this.Form_MainUI_Load);
            this.Resize += new System.EventHandler(this.Form_MainUI_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_NextIPCheck;
        private System.Windows.Forms.Label label_LastDNSSync;
        private System.Windows.Forms.Label label_LastIPCheck;
        private System.Windows.Forms.Label label_UpdateResponse;
        private System.Windows.Forms.Label label_UserIP;
        private System.Windows.Forms.Button button_ForceRefresh;
        private System.Windows.Forms.Button button_Configuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer_NextCheck;
        private System.Windows.Forms.NotifyIcon mynotifyicon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ListBox listBox_ListOfUsersDomains;
    }
}

