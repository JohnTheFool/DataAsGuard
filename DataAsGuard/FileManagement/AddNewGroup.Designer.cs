namespace DataAsGuard.FileManagement
{
    partial class AddNewGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewGroup));
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupList = new System.Windows.Forms.ListBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.membersLabel = new System.Windows.Forms.Label();
            this.membersList = new System.Windows.Forms.ListBox();
            this.addUserToGroupButton = new System.Windows.Forms.Button();
            this.createNewGroupButton = new System.Windows.Forms.Button();
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
            this.BackButton.Location = new System.Drawing.Point(751, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(37, 36);
            this.BackButton.TabIndex = 11;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // groupList
            // 
            this.groupList.FormattingEnabled = true;
            this.groupList.Items.AddRange(new object[] {
            "Group1"});
            this.groupList.Location = new System.Drawing.Point(94, 47);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(120, 381);
            this.groupList.TabIndex = 16;
            this.groupList.SelectedIndexChanged += new System.EventHandler(this.groupList_SelectedIndexChanged);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel.Location = new System.Drawing.Point(117, 24);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(76, 20);
            this.groupLabel.TabIndex = 15;
            this.groupLabel.Text = "Group List";
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersLabel.Location = new System.Drawing.Point(237, 24);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(116, 20);
            this.membersLabel.TabIndex = 17;
            this.membersLabel.Text = "Group Members";
            // 
            // membersList
            // 
            this.membersList.FormattingEnabled = true;
            this.membersList.Items.AddRange(new object[] {
            "User1"});
            this.membersList.Location = new System.Drawing.Point(233, 47);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(120, 381);
            this.membersList.TabIndex = 18;
            // 
            // addUserToGroupButton
            // 
            this.addUserToGroupButton.Location = new System.Drawing.Point(514, 186);
            this.addUserToGroupButton.Name = "addUserToGroupButton";
            this.addUserToGroupButton.Size = new System.Drawing.Size(120, 23);
            this.addUserToGroupButton.TabIndex = 19;
            this.addUserToGroupButton.Text = "Add New User";
            this.addUserToGroupButton.UseVisualStyleBackColor = true;
            // 
            // createNewGroupButton
            // 
            this.createNewGroupButton.Location = new System.Drawing.Point(514, 234);
            this.createNewGroupButton.Name = "createNewGroupButton";
            this.createNewGroupButton.Size = new System.Drawing.Size(120, 23);
            this.createNewGroupButton.TabIndex = 20;
            this.createNewGroupButton.Text = "Create New Group";
            this.createNewGroupButton.UseVisualStyleBackColor = true;
            // 
            // AddNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createNewGroupButton);
            this.Controls.Add(this.addUserToGroupButton);
            this.Controls.Add(this.membersList);
            this.Controls.Add(this.membersLabel);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButton);
            this.Name = "AddNewGroup";
            this.Text = "AddNewGroup";
            this.Load += new System.EventHandler(this.AddNewGroup_Load);
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
        private System.Windows.Forms.Button addUserToGroupButton;
        private System.Windows.Forms.Button createNewGroupButton;
    }
}