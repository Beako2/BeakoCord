namespace BeakoBotNew
{
    partial class botConnector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(botConnector));
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ConnectionStateLabel = new System.Windows.Forms.Label();
            this.saveInfo = new System.Windows.Forms.CheckBox();
            this.outputWindow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serverCountLabel = new System.Windows.Forms.Label();
            this.userCountLabel = new System.Windows.Forms.Label();
            this.serverListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preferences = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 92);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(316, 20);
            this.loginBox.TabIndex = 0;
            this.loginBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bot application token";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beako Bot Connector";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConnectionStateLabel
            // 
            this.ConnectionStateLabel.Location = new System.Drawing.Point(259, 214);
            this.ConnectionStateLabel.Name = "ConnectionStateLabel";
            this.ConnectionStateLabel.Size = new System.Drawing.Size(100, 23);
            this.ConnectionStateLabel.TabIndex = 17;
            // 
            // saveInfo
            // 
            this.saveInfo.AutoSize = true;
            this.saveInfo.Location = new System.Drawing.Point(250, 122);
            this.saveInfo.Name = "saveInfo";
            this.saveInfo.Size = new System.Drawing.Size(81, 17);
            this.saveInfo.TabIndex = 8;
            this.saveInfo.Text = "Save token";
            this.saveInfo.UseVisualStyleBackColor = true;
            // 
            // outputWindow
            // 
            this.outputWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputWindow.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.outputWindow.Location = new System.Drawing.Point(339, 93);
            this.outputWindow.Multiline = true;
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ReadOnly = true;
            this.outputWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputWindow.Size = new System.Drawing.Size(379, 238);
            this.outputWindow.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output";
            // 
            // serverCountLabel
            // 
            this.serverCountLabel.AutoSize = true;
            this.serverCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serverCountLabel.Location = new System.Drawing.Point(404, 64);
            this.serverCountLabel.Name = "serverCountLabel";
            this.serverCountLabel.Size = new System.Drawing.Size(208, 25);
            this.serverCountLabel.TabIndex = 11;
            this.serverCountLabel.Text = "Server count: Offline";
            // 
            // userCountLabel
            // 
            this.userCountLabel.AutoSize = true;
            this.userCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userCountLabel.Location = new System.Drawing.Point(123, 64);
            this.userCountLabel.Name = "userCountLabel";
            this.userCountLabel.Size = new System.Drawing.Size(190, 25);
            this.userCountLabel.TabIndex = 12;
            this.userCountLabel.Text = "User count: Offline";
            // 
            // serverListBox
            // 
            this.serverListBox.FormattingEnabled = true;
            this.serverListBox.Location = new System.Drawing.Point(12, 160);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(316, 121);
            this.serverListBox.TabIndex = 15;
            this.serverListBox.SelectedIndexChanged += new System.EventHandler(this.serverListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Server browser";
            // 
            // preferences
            // 
            this.preferences.Location = new System.Drawing.Point(12, 287);
            this.preferences.Name = "preferences";
            this.preferences.Size = new System.Drawing.Size(316, 44);
            this.preferences.TabIndex = 18;
            this.preferences.Text = "Change bot preferences";
            this.preferences.UseVisualStyleBackColor = true;
            this.preferences.Click += new System.EventHandler(this.preferences_Click);
            // 
            // botConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 354);
            this.Controls.Add(this.preferences);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serverListBox);
            this.Controls.Add(this.userCountLabel);
            this.Controls.Add(this.serverCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.saveInfo);
            this.Controls.Add(this.ConnectionStateLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "botConnector";
            this.Text = "Beako Bot Connector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label ConnectionStateLabel;
        private System.Windows.Forms.CheckBox saveInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label serverCountLabel;
        private System.Windows.Forms.Label userCountLabel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox outputWindow;
        public System.Windows.Forms.ListBox serverListBox;
        private System.Windows.Forms.Button preferences;
    }
}

