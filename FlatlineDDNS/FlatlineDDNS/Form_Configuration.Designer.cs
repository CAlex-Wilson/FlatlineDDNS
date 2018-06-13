namespace FlatlineDDNS
{
    partial class Form_Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Configuration));
            this.comboBox_ListOfDomains = new System.Windows.Forms.ComboBox();
            this.button_RemoveSelectedDomain = new System.Windows.Forms.Button();
            this.button_SaveChangesToDomain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Domain = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_InfoHelp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_ListOfProviders = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_ResetAllInfo = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_EnterAName = new System.Windows.Forms.TextBox();
            this.label_EnterAName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_ListOfDomains
            // 
            this.comboBox_ListOfDomains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ListOfDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_ListOfDomains.FormattingEnabled = true;
            this.comboBox_ListOfDomains.Location = new System.Drawing.Point(12, 35);
            this.comboBox_ListOfDomains.Name = "comboBox_ListOfDomains";
            this.comboBox_ListOfDomains.Size = new System.Drawing.Size(241, 21);
            this.comboBox_ListOfDomains.TabIndex = 8;
            this.comboBox_ListOfDomains.SelectedIndexChanged += new System.EventHandler(this.comboBox_ListOfDomains_SelectedIndexChanged);
            // 
            // button_RemoveSelectedDomain
            // 
            this.button_RemoveSelectedDomain.BackColor = System.Drawing.Color.IndianRed;
            this.button_RemoveSelectedDomain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_RemoveSelectedDomain.FlatAppearance.BorderSize = 0;
            this.button_RemoveSelectedDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveSelectedDomain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveSelectedDomain.ForeColor = System.Drawing.Color.Black;
            this.button_RemoveSelectedDomain.Location = new System.Drawing.Point(329, 12);
            this.button_RemoveSelectedDomain.Name = "button_RemoveSelectedDomain";
            this.button_RemoveSelectedDomain.Size = new System.Drawing.Size(212, 45);
            this.button_RemoveSelectedDomain.TabIndex = 12;
            this.button_RemoveSelectedDomain.Text = "Remove Selected Domain";
            this.button_RemoveSelectedDomain.UseVisualStyleBackColor = false;
            this.button_RemoveSelectedDomain.Click += new System.EventHandler(this.button_RemoveSelectedDomain_Click);
            // 
            // button_SaveChangesToDomain
            // 
            this.button_SaveChangesToDomain.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_SaveChangesToDomain.FlatAppearance.BorderSize = 0;
            this.button_SaveChangesToDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveChangesToDomain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveChangesToDomain.Location = new System.Drawing.Point(329, 212);
            this.button_SaveChangesToDomain.Name = "button_SaveChangesToDomain";
            this.button_SaveChangesToDomain.Size = new System.Drawing.Size(212, 35);
            this.button_SaveChangesToDomain.TabIndex = 7;
            this.button_SaveChangesToDomain.Text = "Save Changes to Current Domain";
            this.button_SaveChangesToDomain.UseVisualStyleBackColor = false;
            this.button_SaveChangesToDomain.Click += new System.EventHandler(this.button_SaveChangesToDomain_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Your Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Your Domain:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(184, 81);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(357, 24);
            this.textBox_Username.TabIndex = 1;
            // 
            // textBox_Domain
            // 
            this.textBox_Domain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Domain.Location = new System.Drawing.Point(184, 147);
            this.textBox_Domain.Name = "textBox_Domain";
            this.textBox_Domain.Size = new System.Drawing.Size(357, 24);
            this.textBox_Domain.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(184, 114);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(357, 24);
            this.textBox_Password.TabIndex = 2;
            // 
            // label_InfoHelp
            // 
            this.label_InfoHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_InfoHelp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoHelp.Location = new System.Drawing.Point(329, 252);
            this.label_InfoHelp.Name = "label_InfoHelp";
            this.label_InfoHelp.Size = new System.Drawing.Size(212, 20);
            this.label_InfoHelp.TabIndex = 20;
            this.label_InfoHelp.Text = "How do I get my login information?";
            this.label_InfoHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_InfoHelp.Click += new System.EventHandler(this.label_InfoHelp_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select a domain to edit:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 33);
            this.label6.TabIndex = 22;
            this.label6.Text = "Your Provider:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_ListOfProviders
            // 
            this.comboBox_ListOfProviders.Enabled = false;
            this.comboBox_ListOfProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ListOfProviders.FormattingEnabled = true;
            this.comboBox_ListOfProviders.Location = new System.Drawing.Point(184, 180);
            this.comboBox_ListOfProviders.Name = "comboBox_ListOfProviders";
            this.comboBox_ListOfProviders.Size = new System.Drawing.Size(357, 26);
            this.comboBox_ListOfProviders.TabIndex = 4;
            this.comboBox_ListOfProviders.Text = "Google Domain";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(553, 68);
            this.label7.TabIndex = 24;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ResetAllInfo
            // 
            this.button_ResetAllInfo.BackColor = System.Drawing.Color.Gold;
            this.button_ResetAllInfo.FlatAppearance.BorderSize = 0;
            this.button_ResetAllInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetAllInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetAllInfo.Location = new System.Drawing.Point(184, 212);
            this.button_ResetAllInfo.Name = "button_ResetAllInfo";
            this.button_ResetAllInfo.Size = new System.Drawing.Size(139, 35);
            this.button_ResetAllInfo.TabIndex = 6;
            this.button_ResetAllInfo.Text = "Reset All Info";
            this.button_ResetAllInfo.UseVisualStyleBackColor = false;
            this.button_ResetAllInfo.Click += new System.EventHandler(this.button_ResetAllInfo_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(16, 225);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Enable Domain?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_EnterAName
            // 
            this.textBox_EnterAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnterAName.Location = new System.Drawing.Point(259, 35);
            this.textBox_EnterAName.Name = "textBox_EnterAName";
            this.textBox_EnterAName.Size = new System.Drawing.Size(282, 22);
            this.textBox_EnterAName.TabIndex = 0;
            this.textBox_EnterAName.Visible = false;
            // 
            // label_EnterAName
            // 
            this.label_EnterAName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_EnterAName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EnterAName.ForeColor = System.Drawing.Color.White;
            this.label_EnterAName.Location = new System.Drawing.Point(253, 8);
            this.label_EnterAName.Name = "label_EnterAName";
            this.label_EnterAName.Size = new System.Drawing.Size(300, 24);
            this.label_EnterAName.TabIndex = 29;
            this.label_EnterAName.Text = "Enter a unique name for the domain entry:";
            this.label_EnterAName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_EnterAName.Visible = false;
            // 
            // Form_Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 276);
            this.Controls.Add(this.label_EnterAName);
            this.Controls.Add(this.textBox_EnterAName);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_ResetAllInfo);
            this.Controls.Add(this.comboBox_ListOfProviders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_InfoHelp);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Domain);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SaveChangesToDomain);
            this.Controls.Add(this.button_RemoveSelectedDomain);
            this.Controls.Add(this.comboBox_ListOfDomains);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(569, 315);
            this.Name = "Form_Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Form_Configuration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RemoveSelectedDomain;
        private System.Windows.Forms.Button button_SaveChangesToDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Domain;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_InfoHelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_ListOfProviders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_ResetAllInfo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_EnterAName;
        private System.Windows.Forms.Label label_EnterAName;
        public System.Windows.Forms.ComboBox comboBox_ListOfDomains;
    }
}