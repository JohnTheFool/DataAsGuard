namespace DataAsGuard.FileManagement
{
    partial class FilePermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePermissions));
            this.fileList = new System.Windows.Forms.ListBox();
            this.permissionGrid = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPermissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAccessed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPermission = new System.Windows.Forms.Button();
            this.fileInformation = new System.Windows.Forms.ListBox();
            this.editPermissionsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.manageGroupsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fileList
            // 
            this.fileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 16;
            this.fileList.Items.AddRange(new object[] {
            "Stuff"});
            this.fileList.Location = new System.Drawing.Point(55, 12);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(219, 580);
            this.fileList.TabIndex = 0;
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
            this.permissionGrid.Size = new System.Drawing.Size(580, 280);
            this.permissionGrid.TabIndex = 2;
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
            // addPermission
            // 
            this.addPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPermission.Location = new System.Drawing.Point(289, 479);
            this.addPermission.Name = "addPermission";
            this.addPermission.Size = new System.Drawing.Size(152, 28);
            this.addPermission.TabIndex = 3;
            this.addPermission.Text = "Add New Permission";
            this.addPermission.UseVisualStyleBackColor = true;
            this.addPermission.Click += new System.EventHandler(this.addPermission_Click);
            // 
            // fileInformation
            // 
            this.fileInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fileInformation.FormattingEnabled = true;
            this.fileInformation.IntegralHeight = false;
            this.fileInformation.ItemHeight = 16;
            this.fileInformation.Items.AddRange(new object[] {
            "Size:",
            "Date Created:",
            "File Owner:",
            "Description:"});
            this.fileInformation.Location = new System.Drawing.Point(289, 12);
            this.fileInformation.Name = "fileInformation";
            this.fileInformation.Size = new System.Drawing.Size(540, 176);
            this.fileInformation.TabIndex = 5;
            // 
            // editPermissionsButton
            // 
            this.editPermissionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editPermissionsButton.Location = new System.Drawing.Point(289, 513);
            this.editPermissionsButton.Name = "editPermissionsButton";
            this.editPermissionsButton.Size = new System.Drawing.Size(152, 28);
            this.editPermissionsButton.TabIndex = 6;
            this.editPermissionsButton.Text = "Edit Permissions";
            this.editPermissionsButton.UseVisualStyleBackColor = true;
            this.editPermissionsButton.Click += new System.EventHandler(this.editPermissionsButton_Click);
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
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(12, 63);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(37, 36);
            this.ProfileButton.TabIndex = 14;
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(835, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteFileButton.Location = new System.Drawing.Point(289, 547);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(152, 28);
            this.deleteFileButton.TabIndex = 16;
            this.deleteFileButton.Text = "Delete File";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // manageGroupsButton
            // 
            this.manageGroupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.manageGroupsButton.Location = new System.Drawing.Point(464, 479);
            this.manageGroupsButton.Name = "manageGroupsButton";
            this.manageGroupsButton.Size = new System.Drawing.Size(152, 28);
            this.manageGroupsButton.TabIndex = 17;
            this.manageGroupsButton.Text = "Manage Groups";
            this.manageGroupsButton.UseVisualStyleBackColor = true;
            this.manageGroupsButton.Click += new System.EventHandler(this.manageGroupsButton_Click);
            // 
            // FilePermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.manageGroupsButton);
            this.Controls.Add(this.deleteFileButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editPermissionsButton);
            this.Controls.Add(this.fileInformation);
            this.Controls.Add(this.addPermission);
            this.Controls.Add(this.permissionGrid);
            this.Controls.Add(this.fileList);
            this.Name = "FilePermissions";
            this.Text = "DataAsguard";
            ((System.ComponentModel.ISupportInitialize)(this.permissionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.DataGridView permissionGrid;
        private System.Windows.Forms.Button addPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAccessed;
        private System.Windows.Forms.ListBox fileInformation;
        private System.Windows.Forms.Button editPermissionsButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Button manageGroupsButton;
    }
}