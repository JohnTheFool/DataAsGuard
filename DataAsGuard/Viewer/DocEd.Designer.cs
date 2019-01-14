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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pColor = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.boldBtn = new System.Windows.Forms.Button();
            this.colorSelectBtn = new System.Windows.Forms.Button();
            this.italicBtn = new System.Windows.Forms.Button();
            this.underlineBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.testBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.rtfBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtfBox_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(799, 51);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(756, 53);
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
            // boldBtn
            // 
            this.boldBtn.Location = new System.Drawing.Point(725, 53);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(24, 25);
            this.boldBtn.TabIndex = 5;
            this.boldBtn.Text = "B";
            this.boldBtn.UseVisualStyleBackColor = true;
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // colorSelectBtn
            // 
            this.colorSelectBtn.Location = new System.Drawing.Point(691, 54);
            this.colorSelectBtn.Name = "colorSelectBtn";
            this.colorSelectBtn.Size = new System.Drawing.Size(28, 24);
            this.colorSelectBtn.TabIndex = 7;
            this.colorSelectBtn.Text = "C";
            this.colorSelectBtn.UseVisualStyleBackColor = true;
            this.colorSelectBtn.Click += new System.EventHandler(this.colorSelectBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.Location = new System.Drawing.Point(662, 55);
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(23, 23);
            this.italicBtn.TabIndex = 8;
            this.italicBtn.Text = "I";
            this.italicBtn.UseVisualStyleBackColor = true;
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // underlineBtn
            // 
            this.underlineBtn.Location = new System.Drawing.Point(630, 55);
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(26, 23);
            this.underlineBtn.TabIndex = 9;
            this.underlineBtn.Text = "U";
            this.underlineBtn.UseVisualStyleBackColor = true;
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.downloadBtn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(128, 22);
            this.downloadBtn.Text = "Download";
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(467, 55);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 11;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // DocEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.underlineBtn);
            this.Controls.Add(this.italicBtn);
            this.Controls.Add(this.colorSelectBtn);
            this.Controls.Add(this.boldBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtfBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocEd";
            this.Text = "DocEd";
            this.Load += new System.EventHandler(this.DocEd_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button boldBtn;
        private System.Windows.Forms.Button colorSelectBtn;
        private System.Windows.Forms.Button italicBtn;
        private System.Windows.Forms.Button underlineBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.ToolStripMenuItem downloadBtn;
    }
}