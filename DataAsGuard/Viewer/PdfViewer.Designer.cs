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
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(192, 28);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(730, 585);
            this.axAcroPDF.TabIndex = 0;
            // 
            // pdfOpen
            // 
            this.pdfOpen.Location = new System.Drawing.Point(1031, 579);
            this.pdfOpen.Name = "pdfOpen";
            this.pdfOpen.Size = new System.Drawing.Size(75, 23);
            this.pdfOpen.TabIndex = 1;
            this.pdfOpen.Text = "&Open";
            this.pdfOpen.UseVisualStyleBackColor = true;
            this.pdfOpen.Click += new System.EventHandler(this.pdfOpen_Click);
            // 
            // PdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 646);
            this.Controls.Add(this.pdfOpen);
            this.Controls.Add(this.axAcroPDF);
            this.Name = "PdfViewer";
            this.Text = "PdfViewer";
            this.Load += new System.EventHandler(this.PdfViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.Button pdfOpen;
    }
}