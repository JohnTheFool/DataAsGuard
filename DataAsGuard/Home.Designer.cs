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
            this.uploadNav = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewImg = new System.Windows.Forms.Button();
            this.viewPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadNav
            // 
            this.uploadNav.AccessibleName = "";
            this.uploadNav.Location = new System.Drawing.Point(12, 12);
            this.uploadNav.Name = "uploadNav";
            this.uploadNav.Size = new System.Drawing.Size(75, 23);
            this.uploadNav.TabIndex = 0;
            this.uploadNav.Text = "Upload File";
            this.uploadNav.UseVisualStyleBackColor = true;
            this.uploadNav.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "";
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewImg
            // 
            this.viewImg.Location = new System.Drawing.Point(12, 114);
            this.viewImg.Name = "viewImg";
            this.viewImg.Size = new System.Drawing.Size(75, 23);
            this.viewImg.TabIndex = 2;
            this.viewImg.Text = "View Image";
            this.viewImg.UseVisualStyleBackColor = true;
            this.viewImg.Click += new System.EventHandler(this.showImg);
            // 
            // viewPdf
            // 
            this.viewPdf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewPdf.Location = new System.Drawing.Point(12, 162);
            this.viewPdf.Name = "viewPdf";
            this.viewPdf.Size = new System.Drawing.Size(75, 23);
            this.viewPdf.TabIndex = 4;
            this.viewPdf.Text = "View PDF";
            this.viewPdf.UseVisualStyleBackColor = true;
            this.viewPdf.Click += new System.EventHandler(this.viewPdf_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewPdf);
            this.Controls.Add(this.viewImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uploadNav);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadNav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewImg;
        private System.Windows.Forms.Button viewPdf;
    }
}

