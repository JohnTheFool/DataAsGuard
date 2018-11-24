namespace DataAsGuard.Editor
{
    partial class EditorForm
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
            this.showPic = new System.Windows.Forms.PictureBox();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.zoom = new System.Windows.Forms.TrackBar();
            this.opnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // showPic
            // 
            this.showPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showPic.Location = new System.Drawing.Point(44, 118);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(1803, 880);
            this.showPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showPic.TabIndex = 2;
            this.showPic.TabStop = false;
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(417, 32);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(403, 20);
            this.fileNameBox.TabIndex = 3;
            this.fileNameBox.TextChanged += new System.EventHandler(this.fileNameBox_TextChanged);
            // 
            // zoom
            // 
            this.zoom.Location = new System.Drawing.Point(417, 67);
            this.zoom.Maximum = 100;
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(372, 45);
            this.zoom.TabIndex = 4;
            this.zoom.Scroll += new System.EventHandler(this.zoom_Scroll);
            // 
            // opnFile
            // 
            this.opnFile.Location = new System.Drawing.Point(826, 32);
            this.opnFile.Name = "opnFile";
            this.opnFile.Size = new System.Drawing.Size(51, 20);
            this.opnFile.TabIndex = 0;
            this.opnFile.Text = "Open";
            this.opnFile.UseVisualStyleBackColor = true;
            this.opnFile.Click += new System.EventHandler(this.opnFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filename";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.showPic);
            this.Controls.Add(this.opnFile);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            this.Load += new System.EventHandler(this.EditorForm_Load);
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
    }
}