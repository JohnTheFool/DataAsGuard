namespace DataAsGuard.Viewer
{
    partial class MetaAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetaAdmin));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePath = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.AdminHome = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(161, 52);
            this.filePath.Margin = new System.Windows.Forms.Padding(4);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(652, 23);
            this.filePath.TabIndex = 1;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(841, 52);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(100, 28);
            this.openFileBtn.TabIndex = 2;
            this.openFileBtn.Text = "Open";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(161, 133);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(652, 339);
            this.textBox.TabIndex = 3;
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Logout.Location = new System.Drawing.Point(1000, 13);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(54, 48);
            this.Logout.TabIndex = 15;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(11, 64);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(44, 38);
            this.settingsButton.TabIndex = 25;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // AdminHome
            // 
            this.AdminHome.Image = ((System.Drawing.Image)(resources.GetObject("AdminHome.Image")));
            this.AdminHome.Location = new System.Drawing.Point(13, 13);
            this.AdminHome.Margin = new System.Windows.Forms.Padding(4);
            this.AdminHome.Name = "AdminHome";
            this.AdminHome.Size = new System.Drawing.Size(42, 42);
            this.AdminHome.TabIndex = 24;
            this.AdminHome.UseVisualStyleBackColor = true;
            this.AdminHome.Click += new System.EventHandler(this.AdminHome_Click);
            // 
            // MetaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.AdminHome);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.filePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MetaAdmin";
            this.Text = "MetaAdmin";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button AdminHome;
    }
}