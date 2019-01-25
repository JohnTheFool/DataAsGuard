namespace DataAsGuard.FileManagement
{
    partial class TransferOwnerUserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferOwnerUserList));
            this.userList = new System.Windows.Forms.ListBox();
            this.transferOwnershipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(45, 9);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(169, 548);
            this.userList.TabIndex = 21;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // transferOwnershipButton
            // 
            this.transferOwnershipButton.Enabled = false;
            this.transferOwnershipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.transferOwnershipButton.Location = new System.Drawing.Point(45, 565);
            this.transferOwnershipButton.Name = "transferOwnershipButton";
            this.transferOwnershipButton.Size = new System.Drawing.Size(169, 29);
            this.transferOwnershipButton.TabIndex = 22;
            this.transferOwnershipButton.Text = "Transfer Ownership";
            this.transferOwnershipButton.UseVisualStyleBackColor = true;
            this.transferOwnershipButton.Click += new System.EventHandler(this.transferOwnershipButton_Click);
            // 
            // TransferOwnerUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 606);
            this.Controls.Add(this.transferOwnershipButton);
            this.Controls.Add(this.userList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferOwnerUserList";
            this.Text = "DataAsguard";
            this.Load += new System.EventHandler(this.TransferOwnerUserList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button transferOwnershipButton;
    }
}