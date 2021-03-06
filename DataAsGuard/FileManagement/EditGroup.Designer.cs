﻿namespace DataAsGuard.FileManagement
{
    partial class EditGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGroup));
            this.userLabel = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.moveToGroupButton = new System.Windows.Forms.Button();
            this.removeFromGroupButton = new System.Windows.Forms.Button();
            this.groupMembers = new System.Windows.Forms.ListBox();
            this.groupNameTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.groupName_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDescription_Text = new System.Windows.Forms.RichTextBox();
            this.updateGroupButton = new System.Windows.Forms.Button();
            this.groupNameTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.userLabel.Location = new System.Drawing.Point(114, 22);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(64, 20);
            this.userLabel.TabIndex = 19;
            this.userLabel.Text = "User List";
            // 
            // userList
            // 
            this.userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(61, 44);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(169, 548);
            this.userList.TabIndex = 20;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupLabel.Location = new System.Drawing.Point(308, 22);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(116, 20);
            this.groupLabel.TabIndex = 21;
            this.groupLabel.Text = "Group Members";
            // 
            // moveToGroupButton
            // 
            this.moveToGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("moveToGroupButton.Image")));
            this.moveToGroupButton.Location = new System.Drawing.Point(237, 216);
            this.moveToGroupButton.Name = "moveToGroupButton";
            this.moveToGroupButton.Size = new System.Drawing.Size(37, 36);
            this.moveToGroupButton.TabIndex = 22;
            this.moveToGroupButton.UseVisualStyleBackColor = true;
            this.moveToGroupButton.Click += new System.EventHandler(this.moveToGroupButton_Click);
            // 
            // removeFromGroupButton
            // 
            this.removeFromGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("removeFromGroupButton.Image")));
            this.removeFromGroupButton.Location = new System.Drawing.Point(237, 330);
            this.removeFromGroupButton.Name = "removeFromGroupButton";
            this.removeFromGroupButton.Size = new System.Drawing.Size(37, 36);
            this.removeFromGroupButton.TabIndex = 23;
            this.removeFromGroupButton.UseVisualStyleBackColor = true;
            this.removeFromGroupButton.Click += new System.EventHandler(this.removeFromGroupButton_Click);
            // 
            // groupMembers
            // 
            this.groupMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupMembers.FormattingEnabled = true;
            this.groupMembers.ItemHeight = 16;
            this.groupMembers.Location = new System.Drawing.Point(280, 44);
            this.groupMembers.Name = "groupMembers";
            this.groupMembers.Size = new System.Drawing.Size(169, 548);
            this.groupMembers.TabIndex = 24;
            // 
            // groupNameTable
            // 
            this.groupNameTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupNameTable.ColumnCount = 2;
            this.groupNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.55132F));
            this.groupNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.44868F));
            this.groupNameTable.Controls.Add(this.groupNameLabel, 0, 0);
            this.groupNameTable.Controls.Add(this.groupName_Text, 1, 0);
            this.groupNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupNameTable.Location = new System.Drawing.Point(468, 104);
            this.groupNameTable.Name = "groupNameTable";
            this.groupNameTable.RowCount = 1;
            this.groupNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.groupNameTable.Size = new System.Drawing.Size(391, 48);
            this.groupNameTable.TabIndex = 25;
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.groupNameLabel.Location = new System.Drawing.Point(18, 14);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(91, 19);
            this.groupNameLabel.TabIndex = 2;
            this.groupNameLabel.Text = "Group Name:";
            this.groupNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.Location = new System.Drawing.Point(465, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Group Description:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDescription_Text
            // 
            this.groupDescription_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupDescription_Text.Location = new System.Drawing.Point(609, 181);
            this.groupDescription_Text.Name = "groupDescription_Text";
            this.groupDescription_Text.Size = new System.Drawing.Size(236, 185);
            this.groupDescription_Text.TabIndex = 27;
            this.groupDescription_Text.Text = "";
            // 
            // updateGroupButton
            // 
            this.updateGroupButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.updateGroupButton.Location = new System.Drawing.Point(571, 455);
            this.updateGroupButton.Name = "updateGroupButton";
            this.updateGroupButton.Size = new System.Drawing.Size(152, 28);
            this.updateGroupButton.TabIndex = 28;
            this.updateGroupButton.Text = "Update Group";
            this.updateGroupButton.UseVisualStyleBackColor = true;
            this.updateGroupButton.Click += new System.EventHandler(this.updateGroupButton_Click);
            // 
            // EditGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.updateGroupButton);
            this.Controls.Add(this.groupDescription_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupNameTable);
            this.Controls.Add(this.groupMembers);
            this.Controls.Add(this.removeFromGroupButton);
            this.Controls.Add(this.moveToGroupButton);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.userLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditGroup";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.EditGroup_Load);
            this.groupNameTable.ResumeLayout(false);
            this.groupNameTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userLabel;
        public System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Button moveToGroupButton;
        private System.Windows.Forms.Button removeFromGroupButton;
        public System.Windows.Forms.ListBox groupMembers;
        private System.Windows.Forms.TableLayoutPanel groupNameTable;
        private System.Windows.Forms.TextBox groupName_Text;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox groupDescription_Text;
        private System.Windows.Forms.Button updateGroupButton;
    }
}