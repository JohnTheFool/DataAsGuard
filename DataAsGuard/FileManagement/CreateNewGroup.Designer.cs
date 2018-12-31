namespace DataAsGuard.FileManagement
{
    partial class CreateNewGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewGroup));
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.removeFromGroupButton = new System.Windows.Forms.Button();
            this.moveToGroupButton = new System.Windows.Forms.Button();
            this.groupMembers = new System.Windows.Forms.ListBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupNameTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupName_Text = new System.Windows.Forms.TextBox();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDescription_Text = new System.Windows.Forms.RichTextBox();
            this.createGroupButton = new System.Windows.Forms.Button();
            this.groupNameTable.SuspendLayout();
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
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(12, 63);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(37, 36);
            this.ProfileButton.TabIndex = 13;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(37, 36);
            this.homeButton.TabIndex = 12;
            this.homeButton.UseVisualStyleBackColor = true;
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
            // userList
            // 
            this.userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(61, 44);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(169, 548);
            this.userList.TabIndex = 15;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.userLabel.Location = new System.Drawing.Point(114, 22);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(64, 20);
            this.userLabel.TabIndex = 16;
            this.userLabel.Text = "User List";
            // 
            // removeFromGroupButton
            // 
            this.removeFromGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("removeFromGroupButton.Image")));
            this.removeFromGroupButton.Location = new System.Drawing.Point(237, 330);
            this.removeFromGroupButton.Name = "removeFromGroupButton";
            this.removeFromGroupButton.Size = new System.Drawing.Size(37, 36);
            this.removeFromGroupButton.TabIndex = 17;
            this.removeFromGroupButton.UseVisualStyleBackColor = true;
            this.removeFromGroupButton.Click += new System.EventHandler(this.removeFromGroupButton_Click);
            // 
            // moveToGroupButton
            // 
            this.moveToGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("moveToGroupButton.Image")));
            this.moveToGroupButton.Location = new System.Drawing.Point(237, 216);
            this.moveToGroupButton.Name = "moveToGroupButton";
            this.moveToGroupButton.Size = new System.Drawing.Size(37, 36);
            this.moveToGroupButton.TabIndex = 18;
            this.moveToGroupButton.UseVisualStyleBackColor = true;
            this.moveToGroupButton.Click += new System.EventHandler(this.moveToGroupButton_Click);
            // 
            // groupMembers
            // 
            this.groupMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupMembers.FormattingEnabled = true;
            this.groupMembers.ItemHeight = 16;
            this.groupMembers.Location = new System.Drawing.Point(280, 44);
            this.groupMembers.Name = "groupMembers";
            this.groupMembers.Size = new System.Drawing.Size(169, 548);
            this.groupMembers.TabIndex = 19;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupLabel.Location = new System.Drawing.Point(308, 22);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(116, 20);
            this.groupLabel.TabIndex = 20;
            this.groupLabel.Text = "Group Members";
            // 
            // groupNameTable
            // 
            this.groupNameTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupNameTable.ColumnCount = 2;
            this.groupNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.55132F));
            this.groupNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.44868F));
            this.groupNameTable.Controls.Add(this.groupName_Text, 1, 0);
            this.groupNameTable.Controls.Add(this.groupNameLabel, 0, 0);
            this.groupNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupNameTable.Location = new System.Drawing.Point(468, 104);
            this.groupNameTable.Name = "groupNameTable";
            this.groupNameTable.RowCount = 1;
            this.groupNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.groupNameTable.Size = new System.Drawing.Size(391, 48);
            this.groupNameTable.TabIndex = 21;
            // 
            // groupName_Text
            // 
            this.groupName_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupName_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupName_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupName_Text.Location = new System.Drawing.Point(141, 12);
            this.groupName_Text.Name = "groupName_Text";
            this.groupName_Text.Size = new System.Drawing.Size(236, 23);
            this.groupName_Text.TabIndex = 1;
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupNameLabel.Location = new System.Drawing.Point(17, 15);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(93, 17);
            this.groupNameLabel.TabIndex = 2;
            this.groupNameLabel.Text = "Group Name:";
            this.groupNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(465, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Group Description:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDescription_Text
            // 
            this.groupDescription_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupDescription_Text.Location = new System.Drawing.Point(609, 181);
            this.groupDescription_Text.Name = "groupDescription_Text";
            this.groupDescription_Text.Size = new System.Drawing.Size(236, 185);
            this.groupDescription_Text.TabIndex = 23;
            this.groupDescription_Text.Text = "";
            // 
            // createGroupButton
            // 
            this.createGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createGroupButton.Location = new System.Drawing.Point(571, 455);
            this.createGroupButton.Name = "createGroupButton";
            this.createGroupButton.Size = new System.Drawing.Size(152, 28);
            this.createGroupButton.TabIndex = 24;
            this.createGroupButton.Text = "Create Group";
            this.createGroupButton.UseVisualStyleBackColor = true;
            this.createGroupButton.Click += new System.EventHandler(this.createGroupButton_Click);
            // 
            // CreateNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.createGroupButton);
            this.Controls.Add(this.groupDescription_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupNameTable);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.groupMembers);
            this.Controls.Add(this.moveToGroupButton);
            this.Controls.Add(this.removeFromGroupButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.BackButton);
            this.Name = "CreateNewGroup";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.CreateNewGroup_Load);
            this.groupNameTable.ResumeLayout(false);
            this.groupNameTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button removeFromGroupButton;
        private System.Windows.Forms.Button moveToGroupButton;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TableLayoutPanel groupNameTable;
        private System.Windows.Forms.TextBox groupName_Text;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox groupDescription_Text;
        private System.Windows.Forms.Button createGroupButton;
        public System.Windows.Forms.ListBox userList;
        public System.Windows.Forms.ListBox groupMembers;
    }
}