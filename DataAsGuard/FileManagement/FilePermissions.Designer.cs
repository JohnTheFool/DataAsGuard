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
            this.fileList = new System.Windows.Forms.ListBox();
            this.editPermission = new System.Windows.Forms.Button();
            this.permissionGrid = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPermissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAccessed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPermission = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.deletePermission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.permissionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Items.AddRange(new object[] {
            "Starhub Lawsuit Agreement",
            "CISCO Fault Tolerance",
            "SingHealth Security Breach Report"});
            this.fileList.Location = new System.Drawing.Point(12, 12);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(262, 407);
            this.fileList.TabIndex = 0;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // editPermission
            // 
            this.editPermission.Location = new System.Drawing.Point(289, 396);
            this.editPermission.Name = "editPermission";
            this.editPermission.Size = new System.Drawing.Size(152, 23);
            this.editPermission.TabIndex = 1;
            this.editPermission.Text = "Edit Permission";
            this.editPermission.UseVisualStyleBackColor = true;
            this.editPermission.Click += new System.EventHandler(this.button1_Click);
            // 
            // permissionGrid
            // 
            this.permissionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.userPermissions,
            this.lastAccessed});
            this.permissionGrid.GridColor = System.Drawing.SystemColors.Control;
            this.permissionGrid.Location = new System.Drawing.Point(289, 12);
            this.permissionGrid.Name = "permissionGrid";
            this.permissionGrid.Size = new System.Drawing.Size(499, 279);
            this.permissionGrid.TabIndex = 2;
            this.permissionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.permissionGrid_CellContentClick);
            // 
            // user
            // 
            this.user.HeaderText = "User";
            this.user.Name = "user";
            // 
            // userPermissions
            // 
            this.userPermissions.HeaderText = "Permissions";
            this.userPermissions.Name = "userPermissions";
            this.userPermissions.Width = 150;
            // 
            // lastAccessed
            // 
            this.lastAccessed.HeaderText = "Last Accessed";
            this.lastAccessed.Name = "lastAccessed";
            this.lastAccessed.Width = 200;
            // 
            // addPermission
            // 
            this.addPermission.Location = new System.Drawing.Point(289, 313);
            this.addPermission.Name = "addPermission";
            this.addPermission.Size = new System.Drawing.Size(152, 23);
            this.addPermission.TabIndex = 3;
            this.addPermission.Text = "Add New Permission";
            this.addPermission.UseVisualStyleBackColor = true;
            this.addPermission.Click += new System.EventHandler(this.button2_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(636, 396);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(152, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // deletePermission
            // 
            this.deletePermission.Location = new System.Drawing.Point(289, 354);
            this.deletePermission.Name = "deletePermission";
            this.deletePermission.Size = new System.Drawing.Size(152, 23);
            this.deletePermission.TabIndex = 5;
            this.deletePermission.Text = "Delete Permission";
            this.deletePermission.UseVisualStyleBackColor = true;
            // 
            // FilePermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletePermission);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addPermission);
            this.Controls.Add(this.permissionGrid);
            this.Controls.Add(this.editPermission);
            this.Controls.Add(this.fileList);
            this.Name = "FilePermissions";
            this.Text = "DataAsGuard";
            ((System.ComponentModel.ISupportInitialize)(this.permissionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Button editPermission;
        private System.Windows.Forms.DataGridView permissionGrid;
        private System.Windows.Forms.Button addPermission;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAccessed;
        private System.Windows.Forms.Button deletePermission;
    }
}