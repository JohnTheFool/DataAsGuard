namespace DataAsGuard.FileManagement
{
    partial class ViewGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGroups));
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupList = new System.Windows.Forms.ListBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.membersLabel = new System.Windows.Forms.Label();
            this.membersList = new System.Windows.Forms.ListBox();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.createGroupButton = new System.Windows.Forms.Button();
            this.fileInformation = new System.Windows.Forms.ListBox();
            this.deleteUserFromGroupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(12, 116);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 36);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(12, 63);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(37, 36);
            this.ProfileButton.TabIndex = 13;
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(835, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(37, 36);
            this.BackButton.TabIndex = 11;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // groupList
            // 
            this.groupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupList.FormattingEnabled = true;
            this.groupList.ItemHeight = 16;
            this.groupList.Items.AddRange(new object[] {
            "Group1"});
            this.groupList.Location = new System.Drawing.Point(94, 47);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(177, 548);
            this.groupList.TabIndex = 16;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel.Location = new System.Drawing.Point(140, 24);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(76, 20);
            this.groupLabel.TabIndex = 15;
            this.groupLabel.Text = "Group List";
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersLabel.Location = new System.Drawing.Point(332, 24);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(116, 20);
            this.membersLabel.TabIndex = 17;
            this.membersLabel.Text = "Group Members";
            // 
            // membersList
            // 
            this.membersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.membersList.FormattingEnabled = true;
            this.membersList.ItemHeight = 16;
            this.membersList.Items.AddRange(new object[] {
            "User1"});
            this.membersList.Location = new System.Drawing.Point(301, 47);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(177, 548);
            this.membersList.TabIndex = 18;
            // 
            // editGroupButton
            // 
            this.editGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editGroupButton.Location = new System.Drawing.Point(573, 300);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(179, 29);
            this.editGroupButton.TabIndex = 19;
            this.editGroupButton.Text = "Edit Group";
            this.editGroupButton.UseVisualStyleBackColor = true;
            // 
            // createGroupButton
            // 
            this.createGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createGroupButton.Location = new System.Drawing.Point(573, 253);
            this.createGroupButton.Name = "createGroupButton";
            this.createGroupButton.Size = new System.Drawing.Size(179, 29);
            this.createGroupButton.TabIndex = 21;
            this.createGroupButton.Text = "Create New Group";
            this.createGroupButton.UseVisualStyleBackColor = true;
            this.createGroupButton.Click += new System.EventHandler(this.createGroupButton_Click);
            // 
            // fileInformation
            // 
            this.fileInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fileInformation.FormattingEnabled = true;
            this.fileInformation.IntegralHeight = false;
            this.fileInformation.ItemHeight = 16;
            this.fileInformation.Items.AddRange(new object[] {
            "Date Created:",
            "Group Owner:"});
            this.fileInformation.Location = new System.Drawing.Point(505, 47);
            this.fileInformation.Name = "fileInformation";
            this.fileInformation.Size = new System.Drawing.Size(308, 176);
            this.fileInformation.TabIndex = 22;
            // 
            // deleteUserFromGroupButton
            // 
            this.deleteUserFromGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteUserFromGroupButton.Location = new System.Drawing.Point(573, 345);
            this.deleteUserFromGroupButton.Name = "deleteUserFromGroupButton";
            this.deleteUserFromGroupButton.Size = new System.Drawing.Size(179, 29);
            this.deleteUserFromGroupButton.TabIndex = 23;
            this.deleteUserFromGroupButton.Text = "Delete User From Group";
            this.deleteUserFromGroupButton.UseVisualStyleBackColor = true;
            // 
            // ViewGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.deleteUserFromGroupButton);
            this.Controls.Add(this.fileInformation);
            this.Controls.Add(this.createGroupButton);
            this.Controls.Add(this.editGroupButton);
            this.Controls.Add(this.membersList);
            this.Controls.Add(this.membersLabel);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButton);
            this.Name = "ViewGroups";
            this.Text = "DataAsguard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox groupList;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.ListBox membersList;
        private System.Windows.Forms.Button editGroupButton;
        private System.Windows.Forms.Button createGroupButton;
        private System.Windows.Forms.ListBox fileInformation;
        private System.Windows.Forms.Button deleteUserFromGroupButton;
    }
}