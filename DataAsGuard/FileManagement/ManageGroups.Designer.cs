namespace DataAsGuard.FileManagement
{
    partial class ManageGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGroups));
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.membersLabel = new System.Windows.Forms.Label();
            this.membersList = new System.Windows.Forms.ListBox();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.createGroupButton = new System.Windows.Forms.Button();
            this.groupInformation = new System.Windows.Forms.RichTextBox();
            this.groupList = new System.Windows.Forms.ListBox();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.transferOwnershipButton = new System.Windows.Forms.Button();
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
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(37, 36);
            this.homeButton.TabIndex = 12;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(835, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(37, 36);
            this.BackButton.TabIndex = 11;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupLabel.Location = new System.Drawing.Point(140, 24);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(76, 20);
            this.groupLabel.TabIndex = 15;
            this.groupLabel.Text = "Group List";
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
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
            this.membersList.Location = new System.Drawing.Point(301, 47);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(177, 548);
            this.membersList.TabIndex = 18;
            this.membersList.SelectedIndexChanged += new System.EventHandler(this.membersList_SelectedIndexChanged);
            // 
            // editGroupButton
            // 
            this.editGroupButton.Enabled = false;
            this.editGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editGroupButton.Location = new System.Drawing.Point(573, 300);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(179, 29);
            this.editGroupButton.TabIndex = 19;
            this.editGroupButton.Text = "Edit Group";
            this.editGroupButton.UseVisualStyleBackColor = true;
            this.editGroupButton.Click += new System.EventHandler(this.editGroupButton_Click);
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
            // groupInformation
            // 
            this.groupInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupInformation.Location = new System.Drawing.Point(505, 47);
            this.groupInformation.Name = "groupInformation";
            this.groupInformation.ReadOnly = true;
            this.groupInformation.Size = new System.Drawing.Size(308, 166);
            this.groupInformation.TabIndex = 24;
            this.groupInformation.Text = "";
            // 
            // groupList
            // 
            this.groupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupList.FormattingEnabled = true;
            this.groupList.ItemHeight = 16;
            this.groupList.Location = new System.Drawing.Point(94, 47);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(177, 548);
            this.groupList.TabIndex = 16;
            this.groupList.SelectedIndexChanged += new System.EventHandler(this.groupList_SelectedIndexChanged);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Enabled = false;
            this.deleteGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteGroupButton.Location = new System.Drawing.Point(573, 347);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(179, 29);
            this.deleteGroupButton.TabIndex = 25;
            this.deleteGroupButton.Text = "Delete Group";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // transferOwnershipButton
            // 
            this.transferOwnershipButton.Enabled = false;
            this.transferOwnershipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.transferOwnershipButton.Location = new System.Drawing.Point(573, 395);
            this.transferOwnershipButton.Name = "transferOwnershipButton";
            this.transferOwnershipButton.Size = new System.Drawing.Size(179, 28);
            this.transferOwnershipButton.TabIndex = 26;
            this.transferOwnershipButton.Text = "Transfer Ownership";
            this.transferOwnershipButton.UseVisualStyleBackColor = true;
            this.transferOwnershipButton.Click += new System.EventHandler(this.transferOwnershipButton_Click);
            // 
            // ManageGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.transferOwnershipButton);
            this.Controls.Add(this.deleteGroupButton);
            this.Controls.Add(this.groupInformation);
            this.Controls.Add(this.createGroupButton);
            this.Controls.Add(this.editGroupButton);
            this.Controls.Add(this.membersList);
            this.Controls.Add(this.membersLabel);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageGroups";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.ManageGroups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.Button editGroupButton;
        private System.Windows.Forms.Button createGroupButton;
        private System.Windows.Forms.RichTextBox groupInformation;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.ListBox groupList;
        private System.Windows.Forms.ListBox membersList;
        private System.Windows.Forms.Button transferOwnershipButton;
    }
}