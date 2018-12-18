﻿namespace DataAsGuard
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
            this.BackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.manageFilesButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.viewImg = new System.Windows.Forms.Button();
            this.viewPdf = new System.Windows.Forms.Button();
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
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(835, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(37, 36);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(12, 63);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(37, 36);
            this.ProfileButton.TabIndex = 5;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // manageFilesButton
            // 
            this.manageFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.manageFilesButton.Location = new System.Drawing.Point(185, 173);
            this.manageFilesButton.Name = "manageFilesButton";
            this.manageFilesButton.Size = new System.Drawing.Size(526, 57);
            this.manageFilesButton.TabIndex = 7;
            this.manageFilesButton.Text = "Manage Files";
            this.manageFilesButton.UseMnemonic = false;
            this.manageFilesButton.UseVisualStyleBackColor = true;
            this.manageFilesButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(12, 115);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 36);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // viewImg
            // 
            this.viewImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
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
            this.viewPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.viewPdf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewPdf.Location = new System.Drawing.Point(12, 221);
            this.viewPdf.Name = "viewPdf";
            this.viewPdf.Size = new System.Drawing.Size(99, 27);
            this.viewPdf.TabIndex = 4;
            this.viewPdf.Text = "View PDF";
            this.viewPdf.UseVisualStyleBackColor = true;
            this.viewPdf.Click += new System.EventHandler(this.viewPdf_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.manageFilesButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.viewPdf);
            this.Controls.Add(this.viewImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button manageFilesButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button viewImg;
        private System.Windows.Forms.Button viewPdf;
    }
}

