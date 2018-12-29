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
            // 
            // profileButton
            // 
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(12, 63);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(37, 36);
            this.profileButton.TabIndex = 12;
            this.profileButton.UseVisualStyleBackColor = true;
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
            this.userListLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListLabel.Location = new System.Drawing.Point(164, 28);
            this.userListLabel.Name = "userListLabel";
            this.userListLabel.Size = new System.Drawing.Size(64, 20);
            this.userListLabel.TabIndex = 15;
            this.userListLabel.Text = "User List";
            // 
            // userSelectedTable
            // 
            this.userSelectedTable.ColumnCount = 2;
            this.userSelectedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userSelectedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userSelectedTable.Controls.Add(this.userSelectedLabel, 0, 0);
            this.userSelectedTable.Controls.Add(this.labelLabel, 0, 0);
            this.userSelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.userSelectedTable.Location = new System.Drawing.Point(418, 150);
            this.userSelectedTable.Name = "userSelectedTable";
            this.userSelectedTable.RowCount = 1;
            this.userSelectedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userSelectedTable.Size = new System.Drawing.Size(252, 40);
            this.userSelectedTable.TabIndex = 16;
            // 
            // userSelectedLabel
            // 
            this.userSelectedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userSelectedLabel.AutoSize = true;
            this.userSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userSelectedLabel.Location = new System.Drawing.Point(168, 11);
            this.userSelectedLabel.Name = "userSelectedLabel";
            this.userSelectedLabel.Size = new System.Drawing.Size(42, 17);
            this.userSelectedLabel.TabIndex = 1;
            this.userSelectedLabel.Text = "None";
            // 
            // labelLabel
            // 
            this.labelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelLabel.Location = new System.Drawing.Point(12, 11);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(101, 17);
            this.labelLabel.TabIndex = 0;
            this.labelLabel.Text = "User Selected:";
            // 
            // permissionCheckBox
            // 
            this.permissionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.permissionCheckBox.FormattingEnabled = true;
            this.permissionCheckBox.Items.AddRange(new object[] {
            "Read",
            "Edit",
            "Download"});
            this.permissionCheckBox.Location = new System.Drawing.Point(486, 216);
            this.permissionCheckBox.Name = "permissionCheckBox";
            this.permissionCheckBox.Size = new System.Drawing.Size(120, 58);
            this.permissionCheckBox.TabIndex = 17;
            // 
            // applyPermButton
            // 
            this.applyPermButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.applyPermButton.Location = new System.Drawing.Point(467, 302);
            this.applyPermButton.Name = "applyPermButton";
            this.applyPermButton.Size = new System.Drawing.Size(152, 46);
            this.applyPermButton.TabIndex = 18;
            this.applyPermButton.Text = "Apply Permissions";
            this.applyPermButton.UseVisualStyleBackColor = true;
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
    }
}