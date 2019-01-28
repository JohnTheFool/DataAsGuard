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
            this.zoom = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // showPic
            // 
            this.showPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showPic.Location = new System.Drawing.Point(13, 85);
            this.showPic.Margin = new System.Windows.Forms.Padding(4);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(858, 498);
            this.showPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showPic.TabIndex = 2;
            this.showPic.TabStop = false;
            // 
            // zoom
            // 
            this.zoom.Location = new System.Drawing.Point(224, 32);
            this.zoom.Margin = new System.Windows.Forms.Padding(4);
            this.zoom.Maximum = 100;
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(496, 45);
            this.zoom.TabIndex = 4;
            this.zoom.Scroll += new System.EventHandler(this.zoom_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 6;
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
            // ImgViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.showPic);
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
        private System.Windows.Forms.TrackBar zoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
    }
}