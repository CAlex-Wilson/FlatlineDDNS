namespace FlatlineDDNS
{
    partial class Form_FirstRunConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FirstRunConfig));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_LoadPriorConfigFile = new System.Windows.Forms.Button();
            this.button_LaunchNewConfig = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_CurrentFileName = new System.Windows.Forms.Label();
            this.button_LaunchPriorConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 17.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(-22, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 47);
            this.label5.TabIndex = 12;
            this.label5.Text = "Welcome to Flatline DDNS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "This is the first run configuration.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(-57, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Developed By Cody Wilson - 2018";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_LoadPriorConfigFile
            // 
            this.button_LoadPriorConfigFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button_LoadPriorConfigFile.FlatAppearance.BorderSize = 0;
            this.button_LoadPriorConfigFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LoadPriorConfigFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoadPriorConfigFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LoadPriorConfigFile.Location = new System.Drawing.Point(27, 192);
            this.button_LoadPriorConfigFile.Name = "button_LoadPriorConfigFile";
            this.button_LoadPriorConfigFile.Size = new System.Drawing.Size(248, 46);
            this.button_LoadPriorConfigFile.TabIndex = 15;
            this.button_LoadPriorConfigFile.Text = "Load in a prior config file";
            this.button_LoadPriorConfigFile.UseVisualStyleBackColor = false;
            this.button_LoadPriorConfigFile.Click += new System.EventHandler(this.button_LoadPriorConfigFile_Click);
            // 
            // button_LaunchNewConfig
            // 
            this.button_LaunchNewConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button_LaunchNewConfig.FlatAppearance.BorderSize = 0;
            this.button_LaunchNewConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LaunchNewConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LaunchNewConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LaunchNewConfig.Location = new System.Drawing.Point(27, 90);
            this.button_LaunchNewConfig.Name = "button_LaunchNewConfig";
            this.button_LaunchNewConfig.Size = new System.Drawing.Size(300, 46);
            this.button_LaunchNewConfig.TabIndex = 16;
            this.button_LaunchNewConfig.Text = "Launch with a fresh config file";
            this.button_LaunchNewConfig.UseVisualStyleBackColor = false;
            this.button_LaunchNewConfig.Click += new System.EventHandler(this.button_LaunchNewConfig_Click);
            // 
            // button_Help
            // 
            this.button_Help.BackColor = System.Drawing.Color.Gold;
            this.button_Help.FlatAppearance.BorderSize = 0;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.Location = new System.Drawing.Point(281, 192);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(46, 46);
            this.button_Help.TabIndex = 17;
            this.button_Help.Text = "?";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Exit.Location = new System.Drawing.Point(84, 476);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(186, 46);
            this.button_Exit.TabIndex = 18;
            this.button_Exit.Text = "Exit Flatline DDNS";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlatlineDDNS.Properties.Resources.FL_DDNS_2;
            this.pictureBox1.Location = new System.Drawing.Point(104, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label_CurrentFileName
            // 
            this.label_CurrentFileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_CurrentFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_CurrentFileName.Location = new System.Drawing.Point(12, 241);
            this.label_CurrentFileName.Name = "label_CurrentFileName";
            this.label_CurrentFileName.Size = new System.Drawing.Size(330, 24);
            this.label_CurrentFileName.TabIndex = 20;
            this.label_CurrentFileName.Text = "No file currently loaded...";
            this.label_CurrentFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_LaunchPriorConfig
            // 
            this.button_LaunchPriorConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button_LaunchPriorConfig.FlatAppearance.BorderSize = 0;
            this.button_LaunchPriorConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LaunchPriorConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LaunchPriorConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_LaunchPriorConfig.Location = new System.Drawing.Point(27, 268);
            this.button_LaunchPriorConfig.Name = "button_LaunchPriorConfig";
            this.button_LaunchPriorConfig.Size = new System.Drawing.Size(300, 46);
            this.button_LaunchPriorConfig.TabIndex = 21;
            this.button_LaunchPriorConfig.Text = "Launch with your loaded config file";
            this.button_LaunchPriorConfig.UseVisualStyleBackColor = false;
            this.button_LaunchPriorConfig.Click += new System.EventHandler(this.button_LaunchPriorConfig_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Or";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(353, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 577);
            this.label4.TabIndex = 23;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 577);
            this.label6.TabIndex = 24;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_FirstRunConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(354, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_LaunchPriorConfig);
            this.Controls.Add(this.label_CurrentFileName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.button_LaunchNewConfig);
            this.Controls.Add(this.button_LoadPriorConfigFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_FirstRunConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_FirstRunConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_LoadPriorConfigFile;
        private System.Windows.Forms.Button button_LaunchNewConfig;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_CurrentFileName;
        private System.Windows.Forms.Button button_LaunchPriorConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}