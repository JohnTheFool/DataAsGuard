namespace DataAsGuard.Profiles.Users
{
    partial class Profilesettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profilesettings));
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.validateUsername = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.validateCaptcha = new System.Windows.Forms.Label();
            this.captchabox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.validatephoneNO = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Validation = new System.Windows.Forms.Label();
            this.RefreshCaptcha = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(17, 123);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(49, 44);
            this.settingsButton.TabIndex = 17;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(17, 70);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(5);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(49, 44);
            this.ProfileButton.TabIndex = 16;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // Home
            // 
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(17, 16);
            this.Home.Margin = new System.Windows.Forms.Padding(5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(49, 44);
            this.Home.TabIndex = 15;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(922, 70);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(49, 44);
            this.Logout.TabIndex = 19;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(921, 16);
            this.BackButton.Margin = new System.Windows.Forms.Padding(5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(49, 44);
            this.BackButton.TabIndex = 18;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.41584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.58416F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Controls.Add(this.validateUsername, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.email, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DOB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.name, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.validateCaptcha, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.captchabox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.phoneNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.validatephoneNO, 2, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 88);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.43038F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.56962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 324);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // validateUsername
            // 
            this.validateUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validateUsername.AutoSize = true;
            this.validateUsername.Location = new System.Drawing.Point(507, 19);
            this.validateUsername.Name = "validateUsername";
            this.validateUsername.Size = new System.Drawing.Size(119, 16);
            this.validateUsername.TabIndex = 42;
            this.validateUsername.Text = "validateUsername";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.username.Location = new System.Drawing.Point(298, 16);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(122, 22);
            this.username.TabIndex = 38;
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Phone Number(No.)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "DOB (DD/MM/YYYY)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name:";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(299, 68);
            this.email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 16);
            this.email.TabIndex = 32;
            this.email.Text = "Email";
            // 
            // DOB
            // 
            this.DOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(299, 173);
            this.DOB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(134, 16);
            this.DOB.TabIndex = 34;
            this.DOB.Text = "DOB (DD/MM/YYYY)";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(298, 228);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 16);
            this.name.TabIndex = 35;
            this.name.Text = "Name:";
            // 
            // validateCaptcha
            // 
            this.validateCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validateCaptcha.AutoSize = true;
            this.validateCaptcha.Location = new System.Drawing.Point(508, 285);
            this.validateCaptcha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validateCaptcha.Name = "validateCaptcha";
            this.validateCaptcha.Size = new System.Drawing.Size(106, 16);
            this.validateCaptcha.TabIndex = 36;
            this.validateCaptcha.Text = "validateCaptcha";
            // 
            // captchabox
            // 
            this.captchabox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.captchabox.Location = new System.Drawing.Point(299, 282);
            this.captchabox.Margin = new System.Windows.Forms.Padding(5);
            this.captchabox.Name = "captchabox";
            this.captchabox.Size = new System.Drawing.Size(121, 22);
            this.captchabox.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(75, 270);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 46);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // phoneNo
            // 
            this.phoneNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneNo.Location = new System.Drawing.Point(297, 115);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(123, 22);
            this.phoneNo.TabIndex = 39;
            this.phoneNo.TextChanged += new System.EventHandler(this.phonenumber_TextChanged);
            // 
            // validatephoneNO
            // 
            this.validatephoneNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validatephoneNO.AutoSize = true;
            this.validatephoneNO.Location = new System.Drawing.Point(508, 118);
            this.validatephoneNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validatephoneNO.Name = "validatephoneNO";
            this.validatephoneNO.Size = new System.Drawing.Size(109, 16);
            this.validatephoneNO.TabIndex = 40;
            this.validatephoneNO.Text = "validatephoneno";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(462, 460);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(100, 28);
            this.UpdateButton.TabIndex = 21;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Validation);
            this.panel1.Location = new System.Drawing.Point(318, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 34);
            this.panel1.TabIndex = 22;
            // 
            // Validation
            // 
            this.Validation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Validation.AutoSize = true;
            this.Validation.Location = new System.Drawing.Point(153, 9);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(68, 17);
            this.Validation.TabIndex = 0;
            this.Validation.Text = "validation";
            // 
            // RefreshCaptcha
            // 
            this.RefreshCaptcha.Location = new System.Drawing.Point(462, 495);
            this.RefreshCaptcha.Name = "RefreshCaptcha";
            this.RefreshCaptcha.Size = new System.Drawing.Size(99, 42);
            this.RefreshCaptcha.TabIndex = 41;
            this.RefreshCaptcha.Text = "Refresh Captcha";
            this.RefreshCaptcha.UseVisualStyleBackColor = true;
            this.RefreshCaptcha.Click += new System.EventHandler(this.RefreshCaptcha_Click);
            // 
            // Profilesettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.RefreshCaptcha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.Home);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profilesettings";
            this.Text = "Profilesettings";
            this.Shown += new System.EventHandler(this.profilesettings_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label validateCaptcha;
        private System.Windows.Forms.TextBox captchabox;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Validation;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.Label validatephoneNO;
        private System.Windows.Forms.Button RefreshCaptcha;
        private System.Windows.Forms.Label validateUsername;
    }
}