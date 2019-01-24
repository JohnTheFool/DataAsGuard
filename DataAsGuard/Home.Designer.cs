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
            this.backButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.manageFilesButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.viewImg = new System.Windows.Forms.Button();
            this.viewPdf = new System.Windows.Forms.Button();
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.viewDoc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.watchVideoBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.toChat = new System.Windows.Forms.Button();
            this.metaAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // pictureBox1
            //
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 175);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            //
            // backButton
            //
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(1252, 74);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 55);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = true;
            //
            // homeButton
            //
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(18, 18);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(56, 55);
            this.homeButton.TabIndex = 4;
            this.homeButton.UseVisualStyleBackColor = true;
            //
            // profileButton
            //
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(18, 97);
            this.profileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(56, 55);
            this.profileButton.TabIndex = 5;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            //
            // manageFilesButton
            //
            this.manageFilesButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.manageFilesButton.Location = new System.Drawing.Point(278, 409);
            this.manageFilesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageFilesButton.Name = "manageFilesButton";
            this.manageFilesButton.Size = new System.Drawing.Size(789, 88);
            this.manageFilesButton.TabIndex = 7;
            this.manageFilesButton.Text = "File Manager";
            this.manageFilesButton.UseMnemonic = false;
            this.manageFilesButton.UseVisualStyleBackColor = true;
            this.manageFilesButton.Click += new System.EventHandler(this.manageFilesButton_Click);
            //
            // settingsButton
            //
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(18, 177);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(56, 55);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.button2_Click);
            //
            // viewImg
            //
            this.viewImg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewImg.Location = new System.Drawing.Point(18, 266);
            this.viewImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewImg.Name = "viewImg";
            this.viewImg.Size = new System.Drawing.Size(148, 45);
            this.viewImg.TabIndex = 2;
            this.viewImg.Text = "View Image";
            this.viewImg.UseVisualStyleBackColor = true;
            this.viewImg.Click += new System.EventHandler(this.showImg);
            //
            // viewPdf
            //
            this.viewPdf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewPdf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewPdf.Location = new System.Drawing.Point(18, 340);
            this.viewPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewPdf.Name = "viewPdf";
            this.viewPdf.Size = new System.Drawing.Size(148, 46);
            this.viewPdf.TabIndex = 4;
            this.viewPdf.Text = "View PDF";
            this.viewPdf.UseVisualStyleBackColor = true;
            this.viewPdf.Click += new System.EventHandler(this.viewPdf_Click);
            //
            // uploadFileButton
            //
            this.uploadFileButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.uploadFileButton.Location = new System.Drawing.Point(278, 266);
            this.uploadFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(789, 88);
            this.uploadFileButton.TabIndex = 9;
            this.uploadFileButton.Text = "Upload File";
            this.uploadFileButton.UseMnemonic = false;
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Click += new System.EventHandler(this.uploadFileButton_Click);
            //
            // viewDoc
            //
            this.viewDoc.Location = new System.Drawing.Point(18, 411);
            this.viewDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewDoc.Name = "viewDoc";
            this.viewDoc.Size = new System.Drawing.Size(112, 35);
            this.viewDoc.TabIndex = 10;
            this.viewDoc.Text = "View Doc";
            this.viewDoc.UseVisualStyleBackColor = true;
            this.viewDoc.Click += new System.EventHandler(this.viewDoc_Click);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(20, 474);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Steganography";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            //
            // watchVideoBtn
            //
            this.watchVideoBtn.Location = new System.Drawing.Point(18, 540);
            this.watchVideoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.watchVideoBtn.Name = "watchVideoBtn";
            this.watchVideoBtn.Size = new System.Drawing.Size(112, 35);
            this.watchVideoBtn.TabIndex = 12;
            this.watchVideoBtn.Text = "Watch Video";
            this.watchVideoBtn.UseVisualStyleBackColor = true;
            this.watchVideoBtn.Click += new System.EventHandler(this.watchVideoBtn_Click);
            //
            // testBtn
            //
            this.testBtn.Location = new System.Drawing.Point(1048, 638);
            this.testBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(112, 35);
            this.testBtn.TabIndex = 13;
            this.testBtn.Text = "TEST";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            //
            // logoutButton
            //
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutButton.Location = new System.Drawing.Point(1160, 18);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(148, 46);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            //
            // toChat
            //
            this.toChat.Location = new System.Drawing.Point(20, 618);
            this.toChat.Name = "toChat";
            this.toChat.Size = new System.Drawing.Size(118, 33);
            this.toChat.TabIndex = 15;
            this.toChat.Text = "Chat";
            this.toChat.UseVisualStyleBackColor = true;
            this.toChat.Click += new System.EventHandler(this.Chat_Click);
            // metaAdmin
            //
            this.metaAdmin.Location = new System.Drawing.Point(12, 396);
            this.metaAdmin.Name = "metaAdmin";
            this.metaAdmin.Size = new System.Drawing.Size(75, 23);
            this.metaAdmin.TabIndex = 14;
            this.metaAdmin.Text = "Meta Admin";
            this.metaAdmin.UseVisualStyleBackColor = true;
            this.metaAdmin.Click += new System.EventHandler(this.metaAdmin_Click);
            //
            // Home
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 940);
            this.Controls.Add(this.toChat);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.uploadFileButton);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.watchVideoBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.viewDoc);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.manageFilesButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.viewPdf);
            this.Controls.Add(this.viewImg);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button manageFilesButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button viewImg;
        private System.Windows.Forms.Button viewPdf;
        private System.Windows.Forms.Button uploadFileButton;
        private System.Windows.Forms.Button viewDoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button watchVideoBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button toChat;
        private System.Windows.Forms.Button metaAdmin;
    }
}
