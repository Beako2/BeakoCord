namespace BeakoBotNew
{
    partial class serverBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverBrowse));
            this.servername = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.userListLabel = new System.Windows.Forms.Label();
            this.kickButton = new System.Windows.Forms.Button();
            this.banButton = new System.Windows.Forms.Button();
            this.channelListBox = new System.Windows.Forms.ListBox();
            this.channelListLabel = new System.Windows.Forms.Label();
            this.msgHistorySave = new System.Windows.Forms.Button();
            this.delChannel = new System.Windows.Forms.Button();
            this.leaveServerButton = new System.Windows.Forms.Button();
            this.serverNetwork = new System.Windows.Forms.Button();
            this.channelSendButton = new System.Windows.Forms.Button();
            this.channelSendLabel = new System.Windows.Forms.Label();
            this.channelSendBox = new System.Windows.Forms.TextBox();
            this.invite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servername
            // 
            this.servername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.servername.AutoSize = true;
            this.servername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servername.Location = new System.Drawing.Point(16, 9);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(86, 31);
            this.servername.TabIndex = 0;
            this.servername.Text = "label1";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(22, 84);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(262, 121);
            this.userListBox.TabIndex = 1;
            // 
            // userListLabel
            // 
            this.userListLabel.AutoSize = true;
            this.userListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListLabel.Location = new System.Drawing.Point(19, 68);
            this.userListLabel.Name = "userListLabel";
            this.userListLabel.Size = new System.Drawing.Size(44, 13);
            this.userListLabel.TabIndex = 2;
            this.userListLabel.Text = "User list";
            // 
            // kickButton
            // 
            this.kickButton.Location = new System.Drawing.Point(22, 211);
            this.kickButton.Name = "kickButton";
            this.kickButton.Size = new System.Drawing.Size(131, 23);
            this.kickButton.TabIndex = 3;
            this.kickButton.Text = "Kick user";
            this.kickButton.UseVisualStyleBackColor = true;
            this.kickButton.Click += new System.EventHandler(this.kickButton_Click);
            // 
            // banButton
            // 
            this.banButton.Location = new System.Drawing.Point(153, 211);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(131, 23);
            this.banButton.TabIndex = 4;
            this.banButton.Text = "Ban User";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // channelListBox
            // 
            this.channelListBox.FormattingEnabled = true;
            this.channelListBox.Location = new System.Drawing.Point(321, 84);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.Size = new System.Drawing.Size(262, 121);
            this.channelListBox.TabIndex = 5;
            // 
            // channelListLabel
            // 
            this.channelListLabel.AutoSize = true;
            this.channelListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelListLabel.Location = new System.Drawing.Point(318, 68);
            this.channelListLabel.Name = "channelListLabel";
            this.channelListLabel.Size = new System.Drawing.Size(65, 13);
            this.channelListLabel.TabIndex = 6;
            this.channelListLabel.Text = "Channel List";
            // 
            // msgHistorySave
            // 
            this.msgHistorySave.Location = new System.Drawing.Point(321, 211);
            this.msgHistorySave.Name = "msgHistorySave";
            this.msgHistorySave.Size = new System.Drawing.Size(131, 23);
            this.msgHistorySave.TabIndex = 7;
            this.msgHistorySave.Text = "Save message history";
            this.msgHistorySave.UseVisualStyleBackColor = true;
            this.msgHistorySave.Click += new System.EventHandler(this.msgHistorySave_Click);
            // 
            // delChannel
            // 
            this.delChannel.Location = new System.Drawing.Point(452, 211);
            this.delChannel.Name = "delChannel";
            this.delChannel.Size = new System.Drawing.Size(131, 23);
            this.delChannel.TabIndex = 8;
            this.delChannel.Text = "Delete Channel";
            this.delChannel.UseVisualStyleBackColor = true;
            this.delChannel.Click += new System.EventHandler(this.delChannel_Click);
            // 
            // leaveServerButton
            // 
            this.leaveServerButton.Location = new System.Drawing.Point(22, 291);
            this.leaveServerButton.Name = "leaveServerButton";
            this.leaveServerButton.Size = new System.Drawing.Size(262, 25);
            this.leaveServerButton.TabIndex = 9;
            this.leaveServerButton.Text = "Leave Server";
            this.leaveServerButton.UseVisualStyleBackColor = true;
            this.leaveServerButton.Click += new System.EventHandler(this.leaveServerButton_Click);
            // 
            // serverNetwork
            // 
            this.serverNetwork.Location = new System.Drawing.Point(22, 260);
            this.serverNetwork.Name = "serverNetwork";
            this.serverNetwork.Size = new System.Drawing.Size(131, 25);
            this.serverNetwork.TabIndex = 10;
            this.serverNetwork.Text = "Server Network Properties";
            this.serverNetwork.UseVisualStyleBackColor = true;
            this.serverNetwork.Click += new System.EventHandler(this.serverNetwork_Click);
            // 
            // channelSendButton
            // 
            this.channelSendButton.Location = new System.Drawing.Point(321, 291);
            this.channelSendButton.Name = "channelSendButton";
            this.channelSendButton.Size = new System.Drawing.Size(264, 23);
            this.channelSendButton.TabIndex = 16;
            this.channelSendButton.Text = "Send";
            this.channelSendButton.UseVisualStyleBackColor = true;
            this.channelSendButton.Click += new System.EventHandler(this.channelSendButton_Click);
            // 
            // channelSendLabel
            // 
            this.channelSendLabel.AutoSize = true;
            this.channelSendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelSendLabel.Location = new System.Drawing.Point(318, 249);
            this.channelSendLabel.Name = "channelSendLabel";
            this.channelSendLabel.Size = new System.Drawing.Size(141, 13);
            this.channelSendLabel.TabIndex = 15;
            this.channelSendLabel.Text = "Send Message Into Channel";
            // 
            // channelSendBox
            // 
            this.channelSendBox.Location = new System.Drawing.Point(321, 265);
            this.channelSendBox.Name = "channelSendBox";
            this.channelSendBox.Size = new System.Drawing.Size(264, 20);
            this.channelSendBox.TabIndex = 14;
            // 
            // invite
            // 
            this.invite.Location = new System.Drawing.Point(153, 260);
            this.invite.Name = "invite";
            this.invite.Size = new System.Drawing.Size(131, 25);
            this.invite.TabIndex = 17;
            this.invite.Text = "Invite";
            this.invite.UseVisualStyleBackColor = true;
            this.invite.Click += new System.EventHandler(this.invite_Click);
            // 
            // serverBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 328);
            this.Controls.Add(this.invite);
            this.Controls.Add(this.channelSendButton);
            this.Controls.Add(this.channelSendLabel);
            this.Controls.Add(this.channelSendBox);
            this.Controls.Add(this.serverNetwork);
            this.Controls.Add(this.leaveServerButton);
            this.Controls.Add(this.delChannel);
            this.Controls.Add(this.msgHistorySave);
            this.Controls.Add(this.channelListLabel);
            this.Controls.Add(this.channelListBox);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.kickButton);
            this.Controls.Add(this.userListLabel);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.servername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "serverBrowse";
            this.Text = "Beako Bot Server Browser";
            this.Load += new System.EventHandler(this.serverBrowse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label servername;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label userListLabel;
        private System.Windows.Forms.Button kickButton;
        private System.Windows.Forms.Button banButton;
        private System.Windows.Forms.ListBox channelListBox;
        private System.Windows.Forms.Label channelListLabel;
        private System.Windows.Forms.Button msgHistorySave;
        private System.Windows.Forms.Button delChannel;
        private System.Windows.Forms.Button leaveServerButton;
        private System.Windows.Forms.Button serverNetwork;
        private System.Windows.Forms.Button channelSendButton;
        private System.Windows.Forms.Label channelSendLabel;
        private System.Windows.Forms.TextBox channelSendBox;
        private System.Windows.Forms.Button invite;
    }
}