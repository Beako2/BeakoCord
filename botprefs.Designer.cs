namespace BeakoBotNew
{
    partial class botprefs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(botprefs));
            this.botnamePrefs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botnamebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gamenamebox = new System.Windows.Forms.TextBox();
            this.profilepicbox = new System.Windows.Forms.TextBox();
            this.pickImage = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botnamePrefs
            // 
            this.botnamePrefs.AutoSize = true;
            this.botnamePrefs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnamePrefs.Location = new System.Drawing.Point(15, 9);
            this.botnamePrefs.Name = "botnamePrefs";
            this.botnamePrefs.Size = new System.Drawing.Size(134, 29);
            this.botnamePrefs.TabIndex = 0;
            this.botnamePrefs.Text = "<no name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bot Name";
            // 
            // botnamebox
            // 
            this.botnamebox.Location = new System.Drawing.Point(20, 88);
            this.botnamebox.MaxLength = 32;
            this.botnamebox.Name = "botnamebox";
            this.botnamebox.Size = new System.Drawing.Size(417, 20);
            this.botnamebox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profile picture";
            // 
            // gamenamebox
            // 
            this.gamenamebox.Location = new System.Drawing.Point(20, 160);
            this.gamenamebox.MaxLength = 32;
            this.gamenamebox.Name = "gamenamebox";
            this.gamenamebox.Size = new System.Drawing.Size(417, 20);
            this.gamenamebox.TabIndex = 5;
            // 
            // profilepicbox
            // 
            this.profilepicbox.Location = new System.Drawing.Point(182, 231);
            this.profilepicbox.MaxLength = 256;
            this.profilepicbox.Name = "profilepicbox";
            this.profilepicbox.ReadOnly = true;
            this.profilepicbox.Size = new System.Drawing.Size(255, 20);
            this.profilepicbox.TabIndex = 6;
            // 
            // pickImage
            // 
            this.pickImage.Location = new System.Drawing.Point(20, 229);
            this.pickImage.Name = "pickImage";
            this.pickImage.Size = new System.Drawing.Size(156, 23);
            this.pickImage.TabIndex = 7;
            this.pickImage.Text = "Choose image";
            this.pickImage.UseVisualStyleBackColor = true;
            this.pickImage.Click += new System.EventHandler(this.pickImage_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(20, 283);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(417, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // botprefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 339);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pickImage);
            this.Controls.Add(this.profilepicbox);
            this.Controls.Add(this.gamenamebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botnamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botnamePrefs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "botprefs";
            this.Text = "Bot preferences";
            this.Load += new System.EventHandler(this.botprefs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label botnamePrefs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox botnamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gamenamebox;
        private System.Windows.Forms.TextBox profilepicbox;
        private System.Windows.Forms.Button pickImage;
        private System.Windows.Forms.Button saveButton;
    }
}