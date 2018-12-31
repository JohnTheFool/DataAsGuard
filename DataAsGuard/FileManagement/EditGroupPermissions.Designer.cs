namespace DataAsGuard.FileManagement
{
    partial class EditGroupPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGroupPermissions));
            this.settingsButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupListLabel = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.ListBox();
            this.groupSelectedTable = new System.Windows.Forms.TableLayoutPanel();
            this.userSelectedLabel = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.groupSelectedTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(12, 115);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 36);
            this.settingsButton.TabIndex = 17;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // profileButton
            // 
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(12, 63);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(37, 36);
            this.profileButton.TabIndex = 16;
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(37, 36);
            this.homeButton.TabIndex = 15;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(835, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(37, 36);
            this.backButton.TabIndex = 14;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // groupListLabel
            // 
            this.groupListLabel.AutoSize = true;
            this.groupListLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupListLabel.Location = new System.Drawing.Point(163, 28);
            this.groupListLabel.Name = "groupListLabel";
            this.groupListLabel.Size = new System.Drawing.Size(76, 20);
            this.groupListLabel.TabIndex = 18;
            this.groupListLabel.Text = "Group List";
            // 
            // groupList
            // 
            this.groupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupList.FormattingEnabled = true;
            this.groupList.ItemHeight = 16;
            this.groupList.Location = new System.Drawing.Point(97, 49);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(208, 532);
            this.groupList.TabIndex = 19;
            // 
            // groupSelectedTable
            // 
            this.groupSelectedTable.ColumnCount = 2;
            this.groupSelectedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupSelectedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupSelectedTable.Controls.Add(this.userSelectedLabel, 0, 0);
            this.groupSelectedTable.Controls.Add(this.labelLabel, 0, 0);
            this.groupSelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupSelectedTable.Location = new System.Drawing.Point(418, 150);
            this.groupSelectedTable.Name = "groupSelectedTable";
            this.groupSelectedTable.RowCount = 1;
            this.groupSelectedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupSelectedTable.Size = new System.Drawing.Size(252, 40);
            this.groupSelectedTable.TabIndex = 20;
            // 
            // userSelectedLabel
            // 
            this.userSelectedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userSelectedLabel.AutoSize = true;
            this.userSelectedLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userSelectedLabel.Location = new System.Drawing.Point(168, 10);
            this.userSelectedLabel.Name = "userSelectedLabel";
            this.userSelectedLabel.Size = new System.Drawing.Size(42, 19);
            this.userSelectedLabel.TabIndex = 1;
            this.userSelectedLabel.Text = "None";
            // 
            // labelLabel
            // 
            this.labelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLabel.Location = new System.Drawing.Point(10, 10);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(105, 19);
            this.labelLabel.TabIndex = 0;
            this.labelLabel.Text = "Group Selected:";
            // 
            // EditGroupPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.groupSelectedTable);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupListLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Name = "EditGroupPermissions";
            this.Text = "DataAsguard";
            this.groupSelectedTable.ResumeLayout(false);
            this.groupSelectedTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label groupListLabel;
        private System.Windows.Forms.ListBox groupList;
        private System.Windows.Forms.TableLayoutPanel groupSelectedTable;
        private System.Windows.Forms.Label userSelectedLabel;
        private System.Windows.Forms.Label labelLabel;
    }
}