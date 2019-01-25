namespace DataAsGuard.ImgViewer
{
    partial class ImgViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImgViewerForm));
            this.showPic = new System.Windows.Forms.PictureBox();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.zoom = new System.Windows.Forms.TrackBar();
            this.opnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // showPic
            // 
            this.showPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showPic.Location = new System.Drawing.Point(31, 156);
            this.showPic.Margin = new System.Windows.Forms.Padding(4);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(813, 427);
            this.showPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showPic.TabIndex = 2;
            this.showPic.TabStop = false;
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(217, 40);
            this.fileNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(536, 23);
            this.fileNameBox.TabIndex = 3;
            this.fileNameBox.TextChanged += new System.EventHandler(this.fileNameBox_TextChanged);
            // 
            // zoom
            // 
            this.zoom.Location = new System.Drawing.Point(232, 83);
            this.zoom.Margin = new System.Windows.Forms.Padding(4);
            this.zoom.Maximum = 100;
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(496, 45);
            this.zoom.TabIndex = 4;
            this.zoom.Scroll += new System.EventHandler(this.zoom_Scroll);
            // 
            // opnFile
            // 
            this.opnFile.Location = new System.Drawing.Point(773, 38);
            this.opnFile.Margin = new System.Windows.Forms.Padding(4);
            this.opnFile.Name = "opnFile";
            this.opnFile.Size = new System.Drawing.Size(59, 25);
            this.opnFile.TabIndex = 0;
            this.opnFile.Text = "Open";
            this.opnFile.UseVisualStyleBackColor = true;
            this.opnFile.Click += new System.EventHandler(this.opnFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filename";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(13, 32);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(63, 28);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "&Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(769, 105);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(88, 23);
            this.downloadBtn.TabIndex = 8;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // ImgViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.showPic);
            this.Controls.Add(this.opnFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImgViewerForm";
            this.Text = "ImgViewerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImgViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.ImgViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox showPic;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.TrackBar zoom;
        private System.Windows.Forms.Button opnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button downloadBtn;
    }
}