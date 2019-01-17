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
            this.permissionGrid = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPermissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAccessed = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.permissionGrid)).BeginInit();
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
            // permissionGrid
            // 
            this.permissionGrid.AllowUserToAddRows = false;
            this.permissionGrid.AllowUserToDeleteRows = false;
            this.permissionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.Group,
            this.userPermissions,
            this.lastAccessed});
            this.permissionGrid.GridColor = System.Drawing.SystemColors.Control;
            this.permissionGrid.Location = new System.Drawing.Point(289, 193);
            this.permissionGrid.Name = "permissionGrid";
            this.permissionGrid.ReadOnly = true;
            this.permissionGrid.ShowEditingIcon = false;
            this.permissionGrid.Size = new System.Drawing.Size(580, 280);
            this.permissionGrid.TabIndex = 2;
            this.permissionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.permissionGrid_CellContentClick);
            // 
            // user
            // 
            this.user.HeaderText = "User";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // userPermissions
            // 
            this.userPermissions.HeaderText = "Permissions";
            this.userPermissions.Name = "userPermissions";
            this.userPermissions.ReadOnly = true;
            this.userPermissions.Width = 150;
            // 
            // lastAccessed
            // 
            this.lastAccessed.HeaderText = "Last Accessed";
            this.lastAccessed.Name = "lastAccessed";
            this.lastAccessed.ReadOnly = true;
            this.lastAccessed.Width = 200;
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
            // FileManagementHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
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
            this.Controls.Add(this.permissionGrid);
            this.Controls.Add(this.fileList);
            this.Name = "FileManagementHub";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.FileManagementHub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permissionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.DataGridView permissionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAccessed;
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
    }
}