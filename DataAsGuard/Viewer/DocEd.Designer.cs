namespace DataAsGuard.Viewer
{
    partial class DocEd
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
            this.rtfBox = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pColor = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfBox
            // 
            this.rtfBox.Location = new System.Drawing.Point(21, 104);
            this.rtfBox.Margin = new System.Windows.Forms.Padding(4);
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.Size = new System.Drawing.Size(816, 402);
            this.rtfBox.TabIndex = 0;
            this.rtfBox.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(767, 54);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(102, 55);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(594, 23);
            this.txtValue.TabIndex = 2;
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(715, 55);
            this.pColor.Margin = new System.Windows.Forms.Padding(4);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(35, 23);
            this.pColor.TabIndex = 3;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(21, 53);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(59, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // DocEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtfBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocEd";
            this.Text = "DocEd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Button backBtn;
    }
}