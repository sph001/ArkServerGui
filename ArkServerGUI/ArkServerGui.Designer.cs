namespace ArkServerGUI
{
    partial class ArkServerGUI
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
            this.MessageOfTheDayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MessageOfTheDayLable = new System.Windows.Forms.Label();
            this.UpdateServerBtn = new System.Windows.Forms.Button();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.PveServerCheckBox = new System.Windows.Forms.CheckBox();
            this.HardcoreCheckBox = new System.Windows.Forms.CheckBox();
            this.CrosshairsCheckBox = new System.Windows.Forms.CheckBox();
            this.ForceNoHudCheckBox = new System.Windows.Forms.CheckBox();
            this.GlobalVoiceChatCheckBox = new System.Windows.Forms.CheckBox();
            this.NoTributeDownloadsCheckBox = new System.Windows.Forms.CheckBox();
            this.AllowThirdPersonCheckBox = new System.Windows.Forms.CheckBox();
            this.NotifyPlayerLeftCheckBox = new System.Windows.Forms.CheckBox();
            this.DontAlwaysNotifyPlayerJoinedCheckBox = new System.Windows.Forms.CheckBox();
            this.MapPlayerLocationCheckBox = new System.Windows.Forms.CheckBox();
            this.SessionNameLabel = new System.Windows.Forms.Label();
            this.SessionNameTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AdminPasswordLabel = new System.Windows.Forms.Label();
            this.AdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.DifficultyTextBox = new System.Windows.Forms.TextBox();
            this.MaxPlayersLabel = new System.Windows.Forms.Label();
            this.MaxPlayersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageOfTheDayRichTextBox
            // 
            this.MessageOfTheDayRichTextBox.Location = new System.Drawing.Point(427, 27);
            this.MessageOfTheDayRichTextBox.Name = "MessageOfTheDayRichTextBox";
            this.MessageOfTheDayRichTextBox.Size = new System.Drawing.Size(222, 199);
            this.MessageOfTheDayRichTextBox.TabIndex = 0;
            this.MessageOfTheDayRichTextBox.Text = "";
            this.MessageOfTheDayRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MessageOfTheDayLable
            // 
            this.MessageOfTheDayLable.AutoSize = true;
            this.MessageOfTheDayLable.Location = new System.Drawing.Point(424, 9);
            this.MessageOfTheDayLable.Name = "MessageOfTheDayLable";
            this.MessageOfTheDayLable.Size = new System.Drawing.Size(100, 13);
            this.MessageOfTheDayLable.TabIndex = 1;
            this.MessageOfTheDayLable.Text = "Message of the day";
            // 
            // UpdateServerBtn
            // 
            this.UpdateServerBtn.Location = new System.Drawing.Point(427, 238);
            this.UpdateServerBtn.Name = "UpdateServerBtn";
            this.UpdateServerBtn.Size = new System.Drawing.Size(91, 23);
            this.UpdateServerBtn.TabIndex = 2;
            this.UpdateServerBtn.Text = "Update server";
            this.UpdateServerBtn.UseVisualStyleBackColor = true;
            this.UpdateServerBtn.Click += new System.EventHandler(this.UpdateServerBtn_Click);
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(571, 238);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(75, 23);
            this.StartServerButton.TabIndex = 3;
            this.StartServerButton.Text = "Start Server";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // PveServerCheckBox
            // 
            this.PveServerCheckBox.AutoSize = true;
            this.PveServerCheckBox.Location = new System.Drawing.Point(12, 12);
            this.PveServerCheckBox.Name = "PveServerCheckBox";
            this.PveServerCheckBox.Size = new System.Drawing.Size(79, 17);
            this.PveServerCheckBox.TabIndex = 4;
            this.PveServerCheckBox.Text = "PVE server";
            this.PveServerCheckBox.UseVisualStyleBackColor = true;
            this.PveServerCheckBox.CheckedChanged += new System.EventHandler(this.PveServerCheckBox_CheckedChanged);
            // 
            // HardcoreCheckBox
            // 
            this.HardcoreCheckBox.AutoSize = true;
            this.HardcoreCheckBox.Location = new System.Drawing.Point(12, 35);
            this.HardcoreCheckBox.Name = "HardcoreCheckBox";
            this.HardcoreCheckBox.Size = new System.Drawing.Size(70, 17);
            this.HardcoreCheckBox.TabIndex = 5;
            this.HardcoreCheckBox.Text = "Hardcore";
            this.HardcoreCheckBox.UseVisualStyleBackColor = true;
            this.HardcoreCheckBox.CheckedChanged += new System.EventHandler(this.HardcoreCheckBox_CheckedChanged);
            // 
            // CrosshairsCheckBox
            // 
            this.CrosshairsCheckBox.AutoSize = true;
            this.CrosshairsCheckBox.Location = new System.Drawing.Point(12, 58);
            this.CrosshairsCheckBox.Name = "CrosshairsCheckBox";
            this.CrosshairsCheckBox.Size = new System.Drawing.Size(74, 17);
            this.CrosshairsCheckBox.TabIndex = 6;
            this.CrosshairsCheckBox.Text = "Crosshairs";
            this.CrosshairsCheckBox.UseVisualStyleBackColor = true;
            this.CrosshairsCheckBox.CheckedChanged += new System.EventHandler(this.CrosshairsCheckBox_CheckedChanged);
            // 
            // ForceNoHudCheckBox
            // 
            this.ForceNoHudCheckBox.AutoSize = true;
            this.ForceNoHudCheckBox.Location = new System.Drawing.Point(12, 80);
            this.ForceNoHudCheckBox.Name = "ForceNoHudCheckBox";
            this.ForceNoHudCheckBox.Size = new System.Drawing.Size(93, 17);
            this.ForceNoHudCheckBox.TabIndex = 7;
            this.ForceNoHudCheckBox.Text = "Force No Hud";
            this.ForceNoHudCheckBox.UseVisualStyleBackColor = true;
            this.ForceNoHudCheckBox.CheckedChanged += new System.EventHandler(this.ForceNoHudCheckBox_CheckedChanged);
            // 
            // GlobalVoiceChatCheckBox
            // 
            this.GlobalVoiceChatCheckBox.AutoSize = true;
            this.GlobalVoiceChatCheckBox.Location = new System.Drawing.Point(12, 103);
            this.GlobalVoiceChatCheckBox.Name = "GlobalVoiceChatCheckBox";
            this.GlobalVoiceChatCheckBox.Size = new System.Drawing.Size(111, 17);
            this.GlobalVoiceChatCheckBox.TabIndex = 8;
            this.GlobalVoiceChatCheckBox.Text = "Global Voice Chat";
            this.GlobalVoiceChatCheckBox.UseVisualStyleBackColor = true;
            this.GlobalVoiceChatCheckBox.CheckedChanged += new System.EventHandler(this.GlobalVoiceChatCheckBox_CheckedChanged);
            // 
            // NoTributeDownloadsCheckBox
            // 
            this.NoTributeDownloadsCheckBox.AutoSize = true;
            this.NoTributeDownloadsCheckBox.Location = new System.Drawing.Point(12, 126);
            this.NoTributeDownloadsCheckBox.Name = "NoTributeDownloadsCheckBox";
            this.NoTributeDownloadsCheckBox.Size = new System.Drawing.Size(132, 17);
            this.NoTributeDownloadsCheckBox.TabIndex = 9;
            this.NoTributeDownloadsCheckBox.Text = "No Tribute Downloads";
            this.NoTributeDownloadsCheckBox.UseVisualStyleBackColor = true;
            this.NoTributeDownloadsCheckBox.CheckedChanged += new System.EventHandler(this.NoTributeDownloadsCheckBox_CheckedChanged);
            // 
            // AllowThirdPersonCheckBox
            // 
            this.AllowThirdPersonCheckBox.AutoSize = true;
            this.AllowThirdPersonCheckBox.Location = new System.Drawing.Point(12, 149);
            this.AllowThirdPersonCheckBox.Name = "AllowThirdPersonCheckBox";
            this.AllowThirdPersonCheckBox.Size = new System.Drawing.Size(114, 17);
            this.AllowThirdPersonCheckBox.TabIndex = 10;
            this.AllowThirdPersonCheckBox.Text = "Allow Third Person";
            this.AllowThirdPersonCheckBox.UseVisualStyleBackColor = true;
            this.AllowThirdPersonCheckBox.CheckedChanged += new System.EventHandler(this.AllowThirdPersonCheckBox_CheckedChanged);
            // 
            // NotifyPlayerLeftCheckBox
            // 
            this.NotifyPlayerLeftCheckBox.AutoSize = true;
            this.NotifyPlayerLeftCheckBox.Location = new System.Drawing.Point(12, 172);
            this.NotifyPlayerLeftCheckBox.Name = "NotifyPlayerLeftCheckBox";
            this.NotifyPlayerLeftCheckBox.Size = new System.Drawing.Size(106, 17);
            this.NotifyPlayerLeftCheckBox.TabIndex = 11;
            this.NotifyPlayerLeftCheckBox.Text = "Notify Player Left";
            this.NotifyPlayerLeftCheckBox.UseVisualStyleBackColor = true;
            this.NotifyPlayerLeftCheckBox.CheckedChanged += new System.EventHandler(this.NotifyPlayerLeftCheckBox_CheckedChanged);
            // 
            // DontAlwaysNotifyPlayerJoinedCheckBox
            // 
            this.DontAlwaysNotifyPlayerJoinedCheckBox.AutoSize = true;
            this.DontAlwaysNotifyPlayerJoinedCheckBox.Location = new System.Drawing.Point(12, 195);
            this.DontAlwaysNotifyPlayerJoinedCheckBox.Name = "DontAlwaysNotifyPlayerJoinedCheckBox";
            this.DontAlwaysNotifyPlayerJoinedCheckBox.Size = new System.Drawing.Size(181, 17);
            this.DontAlwaysNotifyPlayerJoinedCheckBox.TabIndex = 12;
            this.DontAlwaysNotifyPlayerJoinedCheckBox.Text = "Dont Always Notify Player Joined";
            this.DontAlwaysNotifyPlayerJoinedCheckBox.UseVisualStyleBackColor = true;
            this.DontAlwaysNotifyPlayerJoinedCheckBox.CheckedChanged += new System.EventHandler(this.DontAlwaysNotifyPlayerJoinedCheckBox_CheckedChanged);
            // 
            // MapPlayerLocationCheckBox
            // 
            this.MapPlayerLocationCheckBox.AutoSize = true;
            this.MapPlayerLocationCheckBox.Location = new System.Drawing.Point(12, 218);
            this.MapPlayerLocationCheckBox.Name = "MapPlayerLocationCheckBox";
            this.MapPlayerLocationCheckBox.Size = new System.Drawing.Size(123, 17);
            this.MapPlayerLocationCheckBox.TabIndex = 13;
            this.MapPlayerLocationCheckBox.Text = "Map Player Location";
            this.MapPlayerLocationCheckBox.UseVisualStyleBackColor = true;
            this.MapPlayerLocationCheckBox.CheckedChanged += new System.EventHandler(this.MapPlayerLocationCheckBox_CheckedChanged);
            // 
            // SessionNameLabel
            // 
            this.SessionNameLabel.AutoSize = true;
            this.SessionNameLabel.Location = new System.Drawing.Point(222, 9);
            this.SessionNameLabel.Name = "SessionNameLabel";
            this.SessionNameLabel.Size = new System.Drawing.Size(75, 13);
            this.SessionNameLabel.TabIndex = 14;
            this.SessionNameLabel.Text = "Session Name";
            // 
            // SessionNameTextBox
            // 
            this.SessionNameTextBox.Location = new System.Drawing.Point(222, 25);
            this.SessionNameTextBox.Name = "SessionNameTextBox";
            this.SessionNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.SessionNameTextBox.TabIndex = 15;
            this.SessionNameTextBox.TextChanged += new System.EventHandler(this.SessionNameTextBox_TextChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(222, 48);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 16;
            this.PortLabel.Text = "Port";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(223, 64);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(172, 20);
            this.PortTextBox.TabIndex = 17;
            this.PortTextBox.TextChanged += new System.EventHandler(this.PortTextBox_TextChanged);
            this.PortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortTextBox_KeyPress);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(222, 87);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(223, 103);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(172, 20);
            this.PasswordTextBox.TabIndex = 19;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // AdminPasswordLabel
            // 
            this.AdminPasswordLabel.AutoSize = true;
            this.AdminPasswordLabel.Location = new System.Drawing.Point(222, 126);
            this.AdminPasswordLabel.Name = "AdminPasswordLabel";
            this.AdminPasswordLabel.Size = new System.Drawing.Size(85, 13);
            this.AdminPasswordLabel.TabIndex = 20;
            this.AdminPasswordLabel.Text = "Admin Password";
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(223, 142);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(172, 20);
            this.AdminPasswordTextBox.TabIndex = 21;
            this.AdminPasswordTextBox.TextChanged += new System.EventHandler(this.AdminPasswordTextBox_TextChanged);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(222, 205);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(47, 13);
            this.DifficultyLabel.TabIndex = 22;
            this.DifficultyLabel.Text = "Difficulty";
            // 
            // DifficultyTextBox
            // 
            this.DifficultyTextBox.Location = new System.Drawing.Point(224, 221);
            this.DifficultyTextBox.Name = "DifficultyTextBox";
            this.DifficultyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DifficultyTextBox.Size = new System.Drawing.Size(173, 20);
            this.DifficultyTextBox.TabIndex = 23;
            this.DifficultyTextBox.Text = "0";
            this.DifficultyTextBox.TextChanged += new System.EventHandler(this.DifficultyTextBox_TextChanged);
            this.DifficultyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DifficultyTextBox_KeyPress);
            // 
            // MaxPlayersLabel
            // 
            this.MaxPlayersLabel.AutoSize = true;
            this.MaxPlayersLabel.Location = new System.Drawing.Point(222, 165);
            this.MaxPlayersLabel.Name = "MaxPlayersLabel";
            this.MaxPlayersLabel.Size = new System.Drawing.Size(64, 13);
            this.MaxPlayersLabel.TabIndex = 24;
            this.MaxPlayersLabel.Text = "Max Players";
            this.MaxPlayersLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MaxPlayersTextBox
            // 
            this.MaxPlayersTextBox.Location = new System.Drawing.Point(224, 181);
            this.MaxPlayersTextBox.Name = "MaxPlayersTextBox";
            this.MaxPlayersTextBox.Size = new System.Drawing.Size(171, 20);
            this.MaxPlayersTextBox.TabIndex = 25;
            this.MaxPlayersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxPlayersTextBox.TextChanged += new System.EventHandler(this.MaxPlayersTextBox_TextChanged);
            this.MaxPlayersTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxPlayersTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 273);
            this.Controls.Add(this.MaxPlayersTextBox);
            this.Controls.Add(this.MaxPlayersLabel);
            this.Controls.Add(this.DifficultyTextBox);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.AdminPasswordTextBox);
            this.Controls.Add(this.AdminPasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.SessionNameTextBox);
            this.Controls.Add(this.SessionNameLabel);
            this.Controls.Add(this.MapPlayerLocationCheckBox);
            this.Controls.Add(this.DontAlwaysNotifyPlayerJoinedCheckBox);
            this.Controls.Add(this.NotifyPlayerLeftCheckBox);
            this.Controls.Add(this.AllowThirdPersonCheckBox);
            this.Controls.Add(this.NoTributeDownloadsCheckBox);
            this.Controls.Add(this.GlobalVoiceChatCheckBox);
            this.Controls.Add(this.ForceNoHudCheckBox);
            this.Controls.Add(this.CrosshairsCheckBox);
            this.Controls.Add(this.HardcoreCheckBox);
            this.Controls.Add(this.PveServerCheckBox);
            this.Controls.Add(this.StartServerButton);
            this.Controls.Add(this.UpdateServerBtn);
            this.Controls.Add(this.MessageOfTheDayLable);
            this.Controls.Add(this.MessageOfTheDayRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ark Server Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageOfTheDayRichTextBox;
        private System.Windows.Forms.Label MessageOfTheDayLable;
        private System.Windows.Forms.Button UpdateServerBtn;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.CheckBox PveServerCheckBox;
        private System.Windows.Forms.CheckBox HardcoreCheckBox;
        private System.Windows.Forms.CheckBox CrosshairsCheckBox;
        private System.Windows.Forms.CheckBox ForceNoHudCheckBox;
        private System.Windows.Forms.CheckBox GlobalVoiceChatCheckBox;
        private System.Windows.Forms.CheckBox NoTributeDownloadsCheckBox;
        private System.Windows.Forms.CheckBox AllowThirdPersonCheckBox;
        private System.Windows.Forms.CheckBox NotifyPlayerLeftCheckBox;
        private System.Windows.Forms.CheckBox DontAlwaysNotifyPlayerJoinedCheckBox;
        private System.Windows.Forms.CheckBox MapPlayerLocationCheckBox;
        private System.Windows.Forms.Label SessionNameLabel;
        private System.Windows.Forms.TextBox SessionNameTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label AdminPasswordLabel;
        private System.Windows.Forms.TextBox AdminPasswordTextBox;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.TextBox DifficultyTextBox;
        private System.Windows.Forms.Label MaxPlayersLabel;
        private System.Windows.Forms.TextBox MaxPlayersTextBox;
    }
}

