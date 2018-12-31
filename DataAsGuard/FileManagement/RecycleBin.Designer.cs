namespace DataAsGuard.FileManagement
{
    partial class RecycleBin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBin));
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.recycleList = new System.Windows.Forms.ListBox();
            this.recycleLabel = new System.Windows.Forms.Label();
            this.restoreFileButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(12, 115);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 36);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(12, 63);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(37, 36);
            this.ProfileButton.TabIndex = 10;
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(835, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(37, 36);
            this.BackButton.TabIndex = 12;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // recycleList
            // 
            this.recycleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.recycleList.FormattingEnabled = true;
            this.recycleList.ItemHeight = 16;
            this.recycleList.Items.AddRange(new object[] {
            "Old Agreement",
            "Former Starhub Lawsuit"});
            this.recycleList.Location = new System.Drawing.Point(105, 63);
            this.recycleList.Name = "recycleList";
            this.recycleList.Size = new System.Drawing.Size(261, 516);
            this.recycleList.TabIndex = 13;
            // 
            // recycleLabel
            // 
            this.recycleLabel.AutoSize = true;
            this.recycleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.recycleLabel.Location = new System.Drawing.Point(190, 43);
            this.recycleLabel.Name = "recycleLabel";
            this.recycleLabel.Size = new System.Drawing.Size(91, 19);
            this.recycleLabel.TabIndex = 14;
            this.recycleLabel.Text = "Recycled Files";
            // 
            // restoreFileButton
            // 
            this.restoreFileButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.restoreFileButton.Location = new System.Drawing.Point(544, 231);
            this.restoreFileButton.Name = "restoreFileButton";
            this.restoreFileButton.Size = new System.Drawing.Size(75, 27);
            this.restoreFileButton.TabIndex = 15;
            this.restoreFileButton.Text = "Restore File";
            this.restoreFileButton.UseVisualStyleBackColor = true;
            this.restoreFileButton.Click += new System.EventHandler(this.restoreFileButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(441, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(290, 107);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "Date Deleted: 25th December 2017\nFile Size: 10.2 Kb\nDeleted By: Admin1\nPermanent " +
    "Deletion: 25th February 2018";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(522, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selected File Details";
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteFileButton.Location = new System.Drawing.Point(544, 284);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(75, 26);
            this.deleteFileButton.TabIndex = 18;
            this.deleteFileButton.Text = "Delete File";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            // 
            // RecycleBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.deleteFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.restoreFileButton);
            this.Controls.Add(this.recycleLabel);
            this.Controls.Add(this.recycleList);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.button1);
            this.Name = "RecycleBin";
            this.Text = "RecycleBin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox recycleList;
        private System.Windows.Forms.Label recycleLabel;
        private System.Windows.Forms.Button restoreFileButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteFileButton;
    }
}