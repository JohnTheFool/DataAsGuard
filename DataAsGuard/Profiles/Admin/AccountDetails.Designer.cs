﻿namespace DataAsGuard.Profiles.Admin
{
    partial class AccountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetails));
            this.changePassword = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.AdminHome = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datalogGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.label4 = new System.Windows.Forms.Label();
            this.vflag = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.userid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lockbtn = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.statusDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalogGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(72, 12);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(82, 42);
            this.changePassword.TabIndex = 24;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(12, 63);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 38);
            this.settingsButton.TabIndex = 23;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(817, 63);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(52, 50);
            this.Logout.TabIndex = 22;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AdminHome
            // 
            this.AdminHome.Image = ((System.Drawing.Image)(resources.GetObject("AdminHome.Image")));
            this.AdminHome.Location = new System.Drawing.Point(14, 12);
            this.AdminHome.Margin = new System.Windows.Forms.Padding(4);
            this.AdminHome.Name = "AdminHome";
            this.AdminHome.Size = new System.Drawing.Size(35, 42);
            this.AdminHome.TabIndex = 21;
            this.AdminHome.UseVisualStyleBackColor = true;
            this.AdminHome.Click += new System.EventHandler(this.AdminHome_Click);
            // 
            // AddUser
            // 
            this.AddUser.Image = ((System.Drawing.Image)(resources.GetObject("AddUser.Image")));
            this.AddUser.Location = new System.Drawing.Point(817, 12);
            this.AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(52, 44);
            this.AddUser.TabIndex = 20;
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(72, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 275);
            this.panel1.TabIndex = 25;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 266);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datalogGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // datalogGrid
            // 
            this.datalogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datalogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalogGrid.Location = new System.Drawing.Point(3, 3);
            this.datalogGrid.Name = "datalogGrid";
            this.datalogGrid.ReadOnly = true;
            this.datalogGrid.Size = new System.Drawing.Size(714, 231);
            this.datalogGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 195);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // DOB
            // 
            this.DOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(145, 167);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(126, 17);
            this.DOB.TabIndex = 9;
            this.DOB.Text = "DOB(dd/MM/yyyy):";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(145, 130);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // Contact
            // 
            this.Contact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(145, 95);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(56, 17);
            this.Contact.TabIndex = 5;
            this.Contact.Text = "Contact";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact:";
            // 
            // FName
            // 
            this.FName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(145, 56);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(53, 17);
            this.FName.TabIndex = 3;
            this.FName.Text = "FName";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(145, 13);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 17);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "DOB(dd/MM/yyyy):";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "vFlag";
            // 
            // vflag
            // 
            this.vflag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vflag.AutoSize = true;
            this.vflag.Location = new System.Drawing.Point(140, 56);
            this.vflag.Name = "vflag";
            this.vflag.Size = new System.Drawing.Size(38, 17);
            this.vflag.TabIndex = 11;
            this.vflag.Text = "vflag";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.statusDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.userid, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.vflag, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(501, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 128);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // userid
            // 
            this.userid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userid.AutoSize = true;
            this.userid.Location = new System.Drawing.Point(140, 13);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(47, 17);
            this.userid.TabIndex = 13;
            this.userid.Text = "userid";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Userid:";
            // 
            // Lockbtn
            // 
            this.Lockbtn.Location = new System.Drawing.Point(529, 230);
            this.Lockbtn.Name = "Lockbtn";
            this.Lockbtn.Size = new System.Drawing.Size(75, 43);
            this.Lockbtn.TabIndex = 14;
            this.Lockbtn.Text = "Lock";
            this.Lockbtn.UseVisualStyleBackColor = true;
            this.Lockbtn.Click += new System.EventHandler(this.Lockbtn_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(658, 230);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 43);
            this.delete.TabIndex = 28;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "StatusChangeDate";
            // 
            // statusDate
            // 
            this.statusDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusDate.AutoSize = true;
            this.statusDate.Location = new System.Drawing.Point(140, 98);
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(76, 17);
            this.statusDate.TabIndex = 15;
            this.statusDate.Text = "statusDate";
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.Lockbtn);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.AdminHome);
            this.Controls.Add(this.AddUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountDetails";
            this.Text = "AccountDetails";
            this.Shown += new System.EventHandler(this.accountDetails_Shown);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalogGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AdminHome;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vflag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Lockbtn;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView datalogGrid;
        private System.Windows.Forms.Label statusDate;
        private System.Windows.Forms.Label label8;
    }
}