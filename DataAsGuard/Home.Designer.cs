namespace DataAsGuard
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.manageFilesButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.toChat = new System.Windows.Forms.Button();
            this.groupManagerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 114);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(37, 36);
            this.homeButton.TabIndex = 4;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(12, 63);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(37, 36);
            this.profileButton.TabIndex = 5;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // manageFilesButton
            // 
            this.manageFilesButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.manageFilesButton.Location = new System.Drawing.Point(185, 266);
            this.manageFilesButton.Name = "manageFilesButton";
            this.manageFilesButton.Size = new System.Drawing.Size(526, 57);
            this.manageFilesButton.TabIndex = 7;
            this.manageFilesButton.Text = "File Manager";
            this.manageFilesButton.UseMnemonic = false;
            this.manageFilesButton.UseVisualStyleBackColor = true;
            this.manageFilesButton.Click += new System.EventHandler(this.manageFilesButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(12, 115);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 36);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.uploadFileButton.Location = new System.Drawing.Point(185, 173);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(526, 57);
            this.uploadFileButton.TabIndex = 9;
            this.uploadFileButton.Text = "Upload File";
            this.uploadFileButton.UseMnemonic = false;
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Click += new System.EventHandler(this.uploadFileButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutButton.Location = new System.Drawing.Point(773, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(99, 30);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // toChat
            // 
            this.toChat.Image = ((System.Drawing.Image)(resources.GetObject("toChat.Image")));
            this.toChat.Location = new System.Drawing.Point(12, 166);
            this.toChat.Margin = new System.Windows.Forms.Padding(2);
            this.toChat.Name = "toChat";
            this.toChat.Size = new System.Drawing.Size(37, 36);
            this.toChat.TabIndex = 15;
            this.toChat.UseVisualStyleBackColor = true;
            this.toChat.Click += new System.EventHandler(this.Chat_Click);
            // 
            // groupManagerButton
            // 
            this.groupManagerButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.groupManagerButton.Location = new System.Drawing.Point(185, 360);
            this.groupManagerButton.Name = "groupManagerButton";
            this.groupManagerButton.Size = new System.Drawing.Size(526, 57);
            this.groupManagerButton.TabIndex = 17;
            this.groupManagerButton.Text = "Group Manager";
            this.groupManagerButton.UseMnemonic = false;
            this.groupManagerButton.UseVisualStyleBackColor = true;
            this.groupManagerButton.Click += new System.EventHandler(this.groupManagerButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.groupManagerButton);
            this.Controls.Add(this.toChat);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.uploadFileButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.manageFilesButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button manageFilesButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button uploadFileButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button toChat;
        private System.Windows.Forms.Button groupManagerButton;
    }
}
