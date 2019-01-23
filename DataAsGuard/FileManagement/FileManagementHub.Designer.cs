namespace DataAsGuard.FileManagement
{
    partial class FileManagementHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagementHub));
            this.fileList = new System.Windows.Forms.ListBox();
            this.editUserPermButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.manageGroupsButton = new System.Windows.Forms.Button();
            this.editGroupPermButton = new System.Windows.Forms.Button();
            this.fileInformation = new System.Windows.Forms.RichTextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.downloadFileButton = new System.Windows.Forms.Button();
            this.transferOwnershipButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.userPage = new System.Windows.Forms.TabPage();
            this.userPermGrid = new System.Windows.Forms.DataGridView();
            this.userColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.groupPermGrid = new System.Windows.Forms.DataGridView();
            this.groupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupReadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupEditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDownloadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.userPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPermGrid)).BeginInit();
            this.groupPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPermGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fileList
            // 
            this.fileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fileList.FormattingEnabled = true;
            this.fileList.HorizontalScrollbar = true;
            this.fileList.ItemHeight = 16;
            this.fileList.Location = new System.Drawing.Point(55, 12);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(219, 580);
            this.fileList.TabIndex = 0;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            this.fileList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileDoubleClick);
            // 
            // editUserPermButton
            // 
            this.editUserPermButton.Enabled = false;
            this.editUserPermButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editUserPermButton.Location = new System.Drawing.Point(458, 479);
            this.editUserPermButton.Name = "editUserPermButton";
            this.editUserPermButton.Size = new System.Drawing.Size(168, 28);
            this.editUserPermButton.TabIndex = 6;
            this.editUserPermButton.Text = "Edit User Permissions";
            this.editUserPermButton.UseVisualStyleBackColor = true;
            this.editUserPermButton.Click += new System.EventHandler(this.editUserPermButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(12, 115);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 36);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // profileButton
            // 
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(12, 63);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(37, 36);
            this.profileButton.TabIndex = 14;
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(37, 36);
            this.homeButton.TabIndex = 13;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(835, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(37, 36);
            this.backButton.TabIndex = 12;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Enabled = false;
            this.deleteFileButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteFileButton.Location = new System.Drawing.Point(289, 513);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(163, 28);
            this.deleteFileButton.TabIndex = 16;
            this.deleteFileButton.Text = "Delete File";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // manageGroupsButton
            // 
            this.manageGroupsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.manageGroupsButton.Location = new System.Drawing.Point(289, 547);
            this.manageGroupsButton.Name = "manageGroupsButton";
            this.manageGroupsButton.Size = new System.Drawing.Size(163, 28);
            this.manageGroupsButton.TabIndex = 17;
            this.manageGroupsButton.Text = "Manage Groups";
            this.manageGroupsButton.UseVisualStyleBackColor = true;
            this.manageGroupsButton.Click += new System.EventHandler(this.manageGroupsButton_Click);
            // 
            // editGroupPermButton
            // 
            this.editGroupPermButton.Enabled = false;
            this.editGroupPermButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editGroupPermButton.Location = new System.Drawing.Point(458, 513);
            this.editGroupPermButton.Name = "editGroupPermButton";
            this.editGroupPermButton.Size = new System.Drawing.Size(168, 28);
            this.editGroupPermButton.TabIndex = 18;
            this.editGroupPermButton.Text = "Edit Group Permissions";
            this.editGroupPermButton.UseVisualStyleBackColor = true;
            this.editGroupPermButton.Click += new System.EventHandler(this.editGroupPermButton_Click);
            // 
            // fileInformation
            // 
            this.fileInformation.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.fileInformation.Location = new System.Drawing.Point(289, 12);
            this.fileInformation.Name = "fileInformation";
            this.fileInformation.ReadOnly = true;
            this.fileInformation.Size = new System.Drawing.Size(540, 175);
            this.fileInformation.TabIndex = 19;
            this.fileInformation.Text = "";
            // 
            // openFileButton
            // 
            this.openFileButton.Enabled = false;
            this.openFileButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.openFileButton.Location = new System.Drawing.Point(289, 479);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(163, 28);
            this.openFileButton.TabIndex = 20;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // downloadFileButton
            // 
            this.downloadFileButton.Enabled = false;
            this.downloadFileButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.downloadFileButton.Location = new System.Drawing.Point(458, 547);
            this.downloadFileButton.Name = "downloadFileButton";
            this.downloadFileButton.Size = new System.Drawing.Size(168, 28);
            this.downloadFileButton.TabIndex = 21;
            this.downloadFileButton.Text = "Download File";
            this.downloadFileButton.UseVisualStyleBackColor = true;
            this.downloadFileButton.Click += new System.EventHandler(this.downloadFileButton_Click);
            // 
            // transferOwnershipButton
            // 
            this.transferOwnershipButton.Enabled = false;
            this.transferOwnershipButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transferOwnershipButton.Location = new System.Drawing.Point(632, 479);
            this.transferOwnershipButton.Name = "transferOwnershipButton";
            this.transferOwnershipButton.Size = new System.Drawing.Size(168, 28);
            this.transferOwnershipButton.TabIndex = 22;
            this.transferOwnershipButton.Text = "Transfer Ownership";
            this.transferOwnershipButton.UseVisualStyleBackColor = true;
            this.transferOwnershipButton.Click += new System.EventHandler(this.transferOwnershipButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.userPage);
            this.tabControl.Controls.Add(this.groupPage);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabControl.Location = new System.Drawing.Point(289, 193);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(583, 280);
            this.tabControl.TabIndex = 23;
            // 
            // userPage
            // 
            this.userPage.Controls.Add(this.userPermGrid);
            this.userPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPage.Location = new System.Drawing.Point(4, 26);
            this.userPage.Name = "userPage";
            this.userPage.Padding = new System.Windows.Forms.Padding(3);
            this.userPage.Size = new System.Drawing.Size(575, 250);
            this.userPage.TabIndex = 0;
            this.userPage.Text = "User Permissions";
            this.userPage.UseVisualStyleBackColor = true;
            // 
            // userPermGrid
            // 
            this.userPermGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userPermGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userColumn,
            this.readColumn,
            this.editColumn,
            this.downloadColumn});
            this.userPermGrid.Location = new System.Drawing.Point(0, 0);
            this.userPermGrid.Name = "userPermGrid";
            this.userPermGrid.Size = new System.Drawing.Size(575, 254);
            this.userPermGrid.TabIndex = 0;
            // 
            // userColumn
            // 
            this.userColumn.HeaderText = "User";
            this.userColumn.Name = "userColumn";
            this.userColumn.ReadOnly = true;
            this.userColumn.Width = 232;
            // 
            // readColumn
            // 
            this.readColumn.HeaderText = "Read";
            this.readColumn.Name = "readColumn";
            this.readColumn.ReadOnly = true;
            // 
            // editColumn
            // 
            this.editColumn.HeaderText = "Edit";
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            // 
            // downloadColumn
            // 
            this.downloadColumn.HeaderText = "Download";
            this.downloadColumn.Name = "downloadColumn";
            this.downloadColumn.ReadOnly = true;
            // 
            // groupPage
            // 
            this.groupPage.Controls.Add(this.groupPermGrid);
            this.groupPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPage.Location = new System.Drawing.Point(4, 26);
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupPage.Size = new System.Drawing.Size(575, 250);
            this.groupPage.TabIndex = 1;
            this.groupPage.Text = "Group Permissions";
            this.groupPage.UseVisualStyleBackColor = true;
            // 
            // groupPermGrid
            // 
            this.groupPermGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupColumn,
            this.groupReadColumn,
            this.groupEditColumn,
            this.groupDownloadColumn});
            this.groupPermGrid.Location = new System.Drawing.Point(0, 0);
            this.groupPermGrid.Name = "groupPermGrid";
            this.groupPermGrid.Size = new System.Drawing.Size(575, 254);
            this.groupPermGrid.TabIndex = 0;
            // 
            // groupColumn
            // 
            this.groupColumn.HeaderText = "Group";
            this.groupColumn.Name = "groupColumn";
            this.groupColumn.ReadOnly = true;
            this.groupColumn.Width = 232;
            // 
            // groupReadColumn
            // 
            this.groupReadColumn.HeaderText = "Read";
            this.groupReadColumn.Name = "groupReadColumn";
            this.groupReadColumn.ReadOnly = true;
            // 
            // groupEditColumn
            // 
            this.groupEditColumn.HeaderText = "Edit";
            this.groupEditColumn.Name = "groupEditColumn";
            this.groupEditColumn.ReadOnly = true;
            // 
            // groupDownloadColumn
            // 
            this.groupDownloadColumn.HeaderText = "Download";
            this.groupDownloadColumn.Name = "groupDownloadColumn";
            this.groupDownloadColumn.ReadOnly = true;
            // 
            // FileManagementHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.transferOwnershipButton);
            this.Controls.Add(this.downloadFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.fileInformation);
            this.Controls.Add(this.editGroupPermButton);
            this.Controls.Add(this.manageGroupsButton);
            this.Controls.Add(this.deleteFileButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editUserPermButton);
            this.Controls.Add(this.fileList);
            this.Name = "FileManagementHub";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.FileManagementHub_Load);
            this.tabControl.ResumeLayout(false);
            this.userPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPermGrid)).EndInit();
            this.groupPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupPermGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Button editUserPermButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Button manageGroupsButton;
        private System.Windows.Forms.Button editGroupPermButton;
        private System.Windows.Forms.RichTextBox fileInformation;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button downloadFileButton;
        private System.Windows.Forms.Button transferOwnershipButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage userPage;
        private System.Windows.Forms.TabPage groupPage;
        private System.Windows.Forms.DataGridView userPermGrid;
        private System.Windows.Forms.DataGridView groupPermGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn downloadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupReadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupEditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDownloadColumn;
    }
}