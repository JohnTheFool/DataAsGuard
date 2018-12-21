namespace DataAsGuard.FileManagement
{
    partial class FileUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileUpload));
            this.browseButton = new System.Windows.Forms.Button();
            this.browseTable = new System.Windows.Forms.TableLayoutPanel();
            this.fileUploaded = new System.Windows.Forms.TextBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.Label();
            this.fileDescriptionLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.browseTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.browseButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.browseButton.Location = new System.Drawing.Point(288, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(176, 29);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_click);
            // 
            // browseTable
            // 
            this.browseTable.ColumnCount = 2;
            this.browseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.browseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.browseTable.Controls.Add(this.browseButton, 1, 0);
            this.browseTable.Controls.Add(this.fileUploaded, 0, 0);
            this.browseTable.Location = new System.Drawing.Point(182, 28);
            this.browseTable.Name = "browseTable";
            this.browseTable.RowCount = 1;
            this.browseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.browseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.browseTable.Size = new System.Drawing.Size(502, 48);
            this.browseTable.TabIndex = 1;
            // 
            // fileUploaded
            // 
            this.fileUploaded.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileUploaded.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileUploaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileUploaded.Location = new System.Drawing.Point(16, 13);
            this.fileUploaded.Name = "fileUploaded";
            this.fileUploaded.ReadOnly = true;
            this.fileUploaded.Size = new System.Drawing.Size(218, 22);
            this.fileUploaded.TabIndex = 1;
            // 
            // uploadButton
            // 
            this.uploadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uploadButton.Location = new System.Drawing.Point(356, 570);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(176, 29);
            this.uploadButton.TabIndex = 2;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(835, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(37, 36);
            this.BackButton.TabIndex = 8;
            this.BackButton.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(375, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Upload Limit: GB/GB";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fileNameLabel.Location = new System.Drawing.Point(267, 102);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(75, 17);
            this.fileNameLabel.TabIndex = 13;
            this.fileNameLabel.Text = "File Name:";
            // 
            // fileName
            // 
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fileName.Location = new System.Drawing.Point(348, 99);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(245, 23);
            this.fileName.TabIndex = 14;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fileSizeLabel.Location = new System.Drawing.Point(273, 163);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(65, 17);
            this.fileSizeLabel.TabIndex = 15;
            this.fileSizeLabel.Text = "File Size:";
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fileSize.Location = new System.Drawing.Point(344, 163);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(29, 17);
            this.fileSize.TabIndex = 16;
            this.fileSize.Text = "NIL";
            // 
            // fileDescriptionLabel
            // 
            this.fileDescriptionLabel.AutoSize = true;
            this.fileDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fileDescriptionLabel.Location = new System.Drawing.Point(229, 221);
            this.fileDescriptionLabel.Name = "fileDescriptionLabel";
            this.fileDescriptionLabel.Size = new System.Drawing.Size(109, 17);
            this.fileDescriptionLabel.TabIndex = 17;
            this.fileDescriptionLabel.Text = "File Description:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(344, 221);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(249, 253);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // FileUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fileDescriptionLabel);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.browseTable);
            this.Name = "FileUpload";
            this.Text = "DataAsGuard";
            this.browseTable.ResumeLayout(false);
            this.browseTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel browseTable;
        private System.Windows.Forms.TextBox fileUploaded;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label fileSize;
        private System.Windows.Forms.Label fileDescriptionLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}