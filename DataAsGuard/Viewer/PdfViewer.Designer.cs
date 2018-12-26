namespace DataAsGuard.PdfViewer
{
    partial class PdfViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfViewer));
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.pdfOpen = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(161, 34);
            this.axAcroPDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(646, 537);
            this.axAcroPDF.TabIndex = 0;
            // 
            // pdfOpen
            // 
            this.pdfOpen.Location = new System.Drawing.Point(1375, 713);
            this.pdfOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfOpen.Name = "pdfOpen";
            this.pdfOpen.Size = new System.Drawing.Size(100, 28);
            this.pdfOpen.TabIndex = 1;
            this.pdfOpen.Text = "&Open";
            this.pdfOpen.UseVisualStyleBackColor = true;
            this.pdfOpen.Click += new System.EventHandler(this.pdfOpen_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backBtn.Location = new System.Drawing.Point(29, 34);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // PdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pdfOpen);
            this.Controls.Add(this.axAcroPDF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PdfViewer";
            this.Text = "PdfViewer";
            this.Load += new System.EventHandler(this.PdfViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.Button pdfOpen;
        private System.Windows.Forms.Button backBtn;
    }
}