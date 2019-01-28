namespace DataAsGuard.FileManagement
{
    partial class EditUserPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserPermissions));
            this.settingsButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListBox();
            this.userListLabel = new System.Windows.Forms.Label();
            this.userSelectedTable = new System.Windows.Forms.TableLayoutPanel();
            this.labelLabel2 = new System.Windows.Forms.Label();
            this.fileEditedLabel = new System.Windows.Forms.Label();
            this.userSelectedLabel = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.permissionCheckBox = new System.Windows.Forms.CheckedListBox();
            this.applyPermButton = new System.Windows.Forms.Button();
            this.userSelectedTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(12, 115);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 36);
            this.settingsButton.TabIndex = 13;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(12, 63);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(37, 36);
            this.profileButton.TabIndex = 12;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(37, 36);
            this.homeButton.TabIndex = 11;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(835, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(37, 36);
            this.backButton.TabIndex = 10;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // userList
            // 
            this.userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(97, 51);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(208, 532);
            this.userList.TabIndex = 14;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // userListLabel
            // 
            this.userListLabel.AutoSize = true;
            this.userListLabel.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.userListLabel.Location = new System.Drawing.Point(164, 28);
            this.userListLabel.Name = "userListLabel";
            this.userListLabel.Size = new System.Drawing.Size(62, 19);
            this.userListLabel.TabIndex = 15;
            this.userListLabel.Text = "User List";
            // 
            // userSelectedTable
            // 
            this.userSelectedTable.ColumnCount = 2;
            this.userSelectedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.47059F));
            this.userSelectedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.52941F));
            this.userSelectedTable.Controls.Add(this.labelLabel2, 0, 0);
            this.userSelectedTable.Controls.Add(this.fileEditedLabel, 1, 0);
            this.userSelectedTable.Controls.Add(this.userSelectedLabel, 1, 1);
            this.userSelectedTable.Controls.Add(this.labelLabel, 0, 1);
            this.userSelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.userSelectedTable.Location = new System.Drawing.Point(354, 135);
            this.userSelectedTable.Name = "userSelectedTable";
            this.userSelectedTable.RowCount = 2;
            this.userSelectedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.userSelectedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userSelectedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userSelectedTable.Size = new System.Drawing.Size(468, 75);
            this.userSelectedTable.TabIndex = 16;
            // 
            // labelLabel2
            // 
            this.labelLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLabel2.AutoSize = true;
            this.labelLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLabel2.Location = new System.Drawing.Point(20, 10);
            this.labelLabel2.Name = "labelLabel2";
            this.labelLabel2.Size = new System.Drawing.Size(74, 19);
            this.labelLabel2.TabIndex = 21;
            this.labelLabel2.Text = "File Edited:";
            this.labelLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileEditedLabel
            // 
            this.fileEditedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileEditedLabel.AutoSize = true;
            this.fileEditedLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileEditedLabel.Location = new System.Drawing.Point(270, 10);
            this.fileEditedLabel.Name = "fileEditedLabel";
            this.fileEditedLabel.Size = new System.Drawing.Size(42, 19);
            this.fileEditedLabel.TabIndex = 20;
            this.fileEditedLabel.Text = "None";
            this.fileEditedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userSelectedLabel
            // 
            this.userSelectedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userSelectedLabel.AutoSize = true;
            this.userSelectedLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userSelectedLabel.Location = new System.Drawing.Point(270, 47);
            this.userSelectedLabel.Name = "userSelectedLabel";
            this.userSelectedLabel.Size = new System.Drawing.Size(42, 19);
            this.userSelectedLabel.TabIndex = 1;
            this.userSelectedLabel.Text = "None";
            // 
            // labelLabel
            // 
            this.labelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLabel.Location = new System.Drawing.Point(10, 47);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(94, 19);
            this.labelLabel.TabIndex = 0;
            this.labelLabel.Text = "User Selected:";
            // 
            // permissionCheckBox
            // 
            this.permissionCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.permissionCheckBox.FormattingEnabled = true;
            this.permissionCheckBox.Items.AddRange(new object[] {
            "Read",
            "Edit",
            "Download"});
            this.permissionCheckBox.Location = new System.Drawing.Point(486, 220);
            this.permissionCheckBox.Name = "permissionCheckBox";
            this.permissionCheckBox.Size = new System.Drawing.Size(120, 67);
            this.permissionCheckBox.TabIndex = 17;
            // 
            // applyPermButton
            // 
            this.applyPermButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.applyPermButton.Location = new System.Drawing.Point(467, 302);
            this.applyPermButton.Name = "applyPermButton";
            this.applyPermButton.Size = new System.Drawing.Size(152, 46);
            this.applyPermButton.TabIndex = 18;
            this.applyPermButton.Text = "Apply Permissions";
            this.applyPermButton.UseVisualStyleBackColor = true;
            this.applyPermButton.Click += new System.EventHandler(this.applyPermButton_Click);
            // 
            // EditUserPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.applyPermButton);
            this.Controls.Add(this.permissionCheckBox);
            this.Controls.Add(this.userSelectedTable);
            this.Controls.Add(this.userListLabel);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUserPermissions";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.EditUserPermissions_Load);
            this.userSelectedTable.ResumeLayout(false);
            this.userSelectedTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Label userListLabel;
        private System.Windows.Forms.TableLayoutPanel userSelectedTable;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.CheckedListBox permissionCheckBox;
        private System.Windows.Forms.Button applyPermButton;
        private System.Windows.Forms.Label userSelectedLabel;
        private System.Windows.Forms.Label fileEditedLabel;
        private System.Windows.Forms.Label labelLabel2;
    }
}