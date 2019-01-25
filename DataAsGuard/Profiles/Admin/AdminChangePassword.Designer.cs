namespace DataAsGuard.Profiles.Admin
{
    partial class AdminChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChangePassword));
            this.Logout = new System.Windows.Forms.Button();
            this.RefreshCaptcha = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.strengthcheck = new System.Windows.Forms.Label();
            this.validateCaptcha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.validatecPasword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validatePassword = new System.Windows.Forms.Label();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.CPassword = new System.Windows.Forms.TextBox();
            this.captchabox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Validation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(920, 67);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(51, 50);
            this.Logout.TabIndex = 25;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // RefreshCaptcha
            // 
            this.RefreshCaptcha.Location = new System.Drawing.Point(446, 533);
            this.RefreshCaptcha.Name = "RefreshCaptcha";
            this.RefreshCaptcha.Size = new System.Drawing.Size(99, 42);
            this.RefreshCaptcha.TabIndex = 24;
            this.RefreshCaptcha.Text = "Refresh Captcha";
            this.RefreshCaptcha.UseVisualStyleBackColor = true;
            this.RefreshCaptcha.Click += new System.EventHandler(this.RefreshCaptcha_Click);
            // 
            // backbutton
            // 
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.Location = new System.Drawing.Point(922, 13);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(49, 44);
            this.backbutton.TabIndex = 23;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.AdminHome_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(13, 65);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(49, 44);
            this.settingsButton.TabIndex = 22;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(13, 13);
            this.home.Margin = new System.Windows.Forms.Padding(4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(49, 44);
            this.home.TabIndex = 20;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.AdminHome_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(445, 497);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 28);
            this.confirm.TabIndex = 19;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.74683F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.25317F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.strengthcheck, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.validateCaptcha, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.validatecPasword, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.validatePassword, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.oldPassword, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.captchabox, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(217, 97);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 333);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Old Password:";
            // 
            // strengthcheck
            // 
            this.strengthcheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.strengthcheck.AutoSize = true;
            this.strengthcheck.Location = new System.Drawing.Point(286, 139);
            this.strengthcheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strengthcheck.Name = "strengthcheck";
            this.strengthcheck.Size = new System.Drawing.Size(60, 17);
            this.strengthcheck.TabIndex = 26;
            this.strengthcheck.Text = "strength";
            // 
            // validateCaptcha
            // 
            this.validateCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validateCaptcha.AutoSize = true;
            this.validateCaptcha.Location = new System.Drawing.Point(413, 274);
            this.validateCaptcha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validateCaptcha.Name = "validateCaptcha";
            this.validateCaptcha.Size = new System.Drawing.Size(109, 17);
            this.validateCaptcha.TabIndex = 25;
            this.validateCaptcha.Text = "validateCaptcha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(5, 247);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 71);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // validatecPasword
            // 
            this.validatecPasword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validatecPasword.AutoSize = true;
            this.validatecPasword.Location = new System.Drawing.Point(413, 189);
            this.validatecPasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validatecPasword.Name = "validatecPasword";
            this.validatecPasword.Size = new System.Drawing.Size(127, 17);
            this.validatecPasword.TabIndex = 22;
            this.validatecPasword.Text = "validateCPassword";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm New Password";
            // 
            // validatePassword
            // 
            this.validatePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validatePassword.AutoSize = true;
            this.validatePassword.Location = new System.Drawing.Point(413, 96);
            this.validatePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validatePassword.Name = "validatePassword";
            this.validatePassword.Size = new System.Drawing.Size(118, 17);
            this.validatePassword.TabIndex = 21;
            this.validatePassword.Text = "validatePassword";
            // 
            // oldPassword
            // 
            this.oldPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oldPassword.Location = new System.Drawing.Point(227, 24);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '*';
            this.oldPassword.Size = new System.Drawing.Size(126, 23);
            this.oldPassword.TabIndex = 28;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Password.Location = new System.Drawing.Point(227, 93);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(126, 23);
            this.Password.TabIndex = 29;
            this.Password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.Password.Leave += new System.EventHandler(this.password_onleave);
            // 
            // CPassword
            // 
            this.CPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CPassword.Location = new System.Drawing.Point(227, 186);
            this.CPassword.Name = "CPassword";
            this.CPassword.PasswordChar = '*';
            this.CPassword.Size = new System.Drawing.Size(126, 23);
            this.CPassword.TabIndex = 30;
            this.CPassword.Leave += new System.EventHandler(this.cpassword_onleave);
            // 
            // captchabox
            // 
            this.captchabox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.captchabox.Location = new System.Drawing.Point(227, 271);
            this.captchabox.Name = "captchabox";
            this.captchabox.Size = new System.Drawing.Size(126, 23);
            this.captchabox.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Validation);
            this.panel1.Location = new System.Drawing.Point(289, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 53);
            this.panel1.TabIndex = 26;
            // 
            // Validation
            // 
            this.Validation.AutoSize = true;
            this.Validation.Location = new System.Drawing.Point(156, 21);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(70, 17);
            this.Validation.TabIndex = 0;
            this.Validation.Text = "Validation";
            // 
            // AdminChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.RefreshCaptcha);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.home);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminChangePassword";
            this.Text = "AdminChangePassword";
            this.Shown += new System.EventHandler(this.ChangePassword_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button RefreshCaptcha;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label strengthcheck;
        private System.Windows.Forms.Label validateCaptcha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label validatecPasword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label validatePassword;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox CPassword;
        private System.Windows.Forms.TextBox captchabox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Validation;
    }
}