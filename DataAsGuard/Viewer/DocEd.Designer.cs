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
            this.SuspendLayout();
            // 
            // rtfBox
            // 
            this.rtfBox.Location = new System.Drawing.Point(12, 85);
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.Size = new System.Drawing.Size(767, 353);
            this.rtfBox.TabIndex = 0;
            this.rtfBox.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(683, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(35, 35);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(582, 20);
            this.txtValue.TabIndex = 2;
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(632, 35);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(34, 22);
            this.pColor.TabIndex = 3;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            // 
            // DocEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtfBox);
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
    }
}