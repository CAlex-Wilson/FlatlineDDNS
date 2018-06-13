namespace FlatlineDDNS
{
    partial class Form_PriorConfigHelp
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
            this.label5 = new System.Windows.Forms.Label();
            this.label_ClientPath = new System.Windows.Forms.Label();
            this.button_TakeMeThere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(98, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 47);
            this.label5.TabIndex = 13;
            this.label5.Text = "Flatline DDNS configuration files are named:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ClientPath
            // 
            this.label_ClientPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_ClientPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ClientPath.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientPath.ForeColor = System.Drawing.Color.Black;
            this.label_ClientPath.Location = new System.Drawing.Point(12, 66);
            this.label_ClientPath.Name = "label_ClientPath";
            this.label_ClientPath.Size = new System.Drawing.Size(623, 47);
            this.label_ClientPath.TabIndex = 14;
            this.label_ClientPath.Text = "configfile.xml";
            this.label_ClientPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_TakeMeThere
            // 
            this.button_TakeMeThere.BackColor = System.Drawing.Color.Gainsboro;
            this.button_TakeMeThere.FlatAppearance.BorderSize = 0;
            this.button_TakeMeThere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TakeMeThere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TakeMeThere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_TakeMeThere.Location = new System.Drawing.Point(218, 120);
            this.button_TakeMeThere.Name = "button_TakeMeThere";
            this.button_TakeMeThere.Size = new System.Drawing.Size(211, 46);
            this.button_TakeMeThere.TabIndex = 16;
            this.button_TakeMeThere.Text = "Exit Help";
            this.button_TakeMeThere.UseVisualStyleBackColor = false;
            this.button_TakeMeThere.Click += new System.EventHandler(this.button_TakeMeThere_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(98, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 106);
            this.label1.TabIndex = 17;
            this.label1.Text = "Config files are created, by default, within the installed root directory of the " +
    "program.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_PriorConfigHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(647, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_TakeMeThere);
            this.Controls.Add(this.label_ClientPath);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(663, 313);
            this.MinimumSize = new System.Drawing.Size(663, 313);
            this.Name = "Form_PriorConfigHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prior Config Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_ClientPath;
        private System.Windows.Forms.Button button_TakeMeThere;
        private System.Windows.Forms.Label label1;
    }
}