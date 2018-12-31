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
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(835, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(37, 36);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(37, 36);
            this.homeButton.TabIndex = 4;
            this.homeButton.UseVisualStyleBackColor = true;
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
            this.manageFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            // viewImg
            // 
            this.viewImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.viewImg.Location = new System.Drawing.Point(12, 173);
            this.viewImg.Name = "viewImg";
            this.viewImg.Size = new System.Drawing.Size(99, 25);
            this.viewImg.TabIndex = 2;
            this.viewImg.Text = "View Image";
            this.viewImg.UseVisualStyleBackColor = true;
            this.viewImg.Click += new System.EventHandler(this.showImg);
            // 
            // viewPdf
            // 
            this.viewPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.viewPdf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewPdf.Location = new System.Drawing.Point(12, 221);
            this.viewPdf.Name = "viewPdf";
            this.viewPdf.Size = new System.Drawing.Size(99, 27);
            this.viewPdf.TabIndex = 4;
            this.viewPdf.Text = "View PDF";
            this.viewPdf.UseVisualStyleBackColor = true;
            this.viewPdf.Click += new System.EventHandler(this.viewPdf_Click);
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uploadFileButton.Location = new System.Drawing.Point(185, 173);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(526, 57);
            this.uploadFileButton.TabIndex = 9;
            this.uploadFileButton.Text = "Upload File";
            this.uploadFileButton.UseMnemonic = false;
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Click += new System.EventHandler(this.uploadFileButton_Click);
            // viewDoc
            // 
            this.viewDoc.Location = new System.Drawing.Point(12, 267);
            this.viewDoc.Name = "viewDoc";
            this.viewDoc.Size = new System.Drawing.Size(75, 23);
            this.viewDoc.TabIndex = 10;
            this.viewDoc.Text = "View Doc";
            this.viewDoc.UseVisualStyleBackColor = true;
            this.viewDoc.Click += new System.EventHandler(this.viewDoc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Steganography";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.uploadFileButton);
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

