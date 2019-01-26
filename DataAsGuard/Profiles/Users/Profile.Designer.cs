namespace DataAsGuard.Profiles.Users
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DOB = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chgpass = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(122, 98);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.chgpass);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(774, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.04663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.95337F));
            this.tableLayoutPanel1.Controls.Add(this.DOB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Email, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Contact, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 179);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // DOB
            // 
            this.DOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(259, 150);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(126, 17);
            this.DOB.TabIndex = 9;
            this.DOB.Text = "DOB(dd/MM/yyyy):";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(259, 112);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // Contact
            // 
            this.Contact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(259, 76);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(56, 17);
            this.Contact.TabIndex = 5;
            this.Contact.Text = "Contact";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact:";
            // 
            // FName
            // 
            this.FName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(259, 41);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(53, 17);
            this.FName.TabIndex = 3;
            this.FName.Text = "FName";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(259, 8);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 17);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "DOB(dd/MM/yyyy):";
            // 
            // chgpass
            // 
            this.chgpass.Location = new System.Drawing.Point(321, 226);
            this.chgpass.Margin = new System.Windows.Forms.Padding(4);
            this.chgpass.Name = "chgpass";
            this.chgpass.Size = new System.Drawing.Size(133, 50);
            this.chgpass.TabIndex = 0;
            this.chgpass.Text = "Change Password";
            this.chgpass.UseVisualStyleBackColor = true;
            this.chgpass.Click += new System.EventHandler(this.chgpass_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(774, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(16, 140);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(49, 44);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(16, 76);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(49, 44);
            this.ProfileButton.TabIndex = 13;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(16, 14);
            this.home.Margin = new System.Windows.Forms.Padding(4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(49, 44);
            this.home.TabIndex = 12;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(920, 14);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(52, 50);
            this.Logout.TabIndex = 16;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.home);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Shown += new System.EventHandler(this.profile_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button chgpass;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Timer timer1;
    }
}