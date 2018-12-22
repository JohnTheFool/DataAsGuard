namespace DataAsGuard.Profiles.Users
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
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
            this.confirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RefreshCaptcha = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.74683F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.25317F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(163, 72);
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 27);
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
            this.strengthcheck.Location = new System.Drawing.Point(212, 139);
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
            this.validateCaptcha.Location = new System.Drawing.Point(317, 274);
            this.validateCaptcha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validateCaptcha.Name = "validateCaptcha";
            this.validateCaptcha.Size = new System.Drawing.Size(109, 17);
            this.validateCaptcha.TabIndex = 25;
            this.validateCaptcha.Text = "validateCaptcha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(14, 247);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 71);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // validatecPasword
            // 
            this.validatecPasword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validatecPasword.AutoSize = true;
            this.validatecPasword.Location = new System.Drawing.Point(317, 189);
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
            this.label1.Location = new System.Drawing.Point(67, 96);
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
            this.label2.Location = new System.Drawing.Point(15, 189);
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
            this.validatePassword.Location = new System.Drawing.Point(317, 96);
            this.validatePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validatePassword.Name = "validatePassword";
            this.validatePassword.Size = new System.Drawing.Size(118, 17);
            this.validatePassword.TabIndex = 21;
            this.validatePassword.Text = "validatePassword";
            // 
            // oldPassword
            // 
            this.oldPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oldPassword.Location = new System.Drawing.Point(174, 24);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '*';
            this.oldPassword.Size = new System.Drawing.Size(126, 23);
            this.oldPassword.TabIndex = 28;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Password.Location = new System.Drawing.Point(174, 93);
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
            this.CPassword.Location = new System.Drawing.Point(174, 186);
            this.CPassword.Name = "CPassword";
            this.CPassword.PasswordChar = '*';
            this.CPassword.Size = new System.Drawing.Size(126, 23);
            this.CPassword.TabIndex = 30;
            this.CPassword.Leave += new System.EventHandler(this.cpassword_onleave);
            // 
            // captchabox
            // 
            this.captchabox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.captchabox.Location = new System.Drawing.Point(174, 271);
            this.captchabox.Name = "captchabox";
            this.captchabox.Size = new System.Drawing.Size(126, 23);
            this.captchabox.TabIndex = 31;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(378, 473);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 28);
            this.confirm.TabIndex = 1;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 44);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(16, 79);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(49, 44);
            this.ProfileButton.TabIndex = 11;
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(16, 139);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(49, 44);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(822, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RefreshCaptcha
            // 
            this.RefreshCaptcha.Location = new System.Drawing.Point(379, 509);
            this.RefreshCaptcha.Name = "RefreshCaptcha";
            this.RefreshCaptcha.Size = new System.Drawing.Size(99, 42);
            this.RefreshCaptcha.TabIndex = 16;
            this.RefreshCaptcha.Text = "Refresh Captcha";
            this.RefreshCaptcha.UseVisualStyleBackColor = true;
            this.RefreshCaptcha.Click += new System.EventHandler(this.RefreshCaptcha_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.RefreshCaptcha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Shown += new System.EventHandler(this.ChangePassword_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label validatePassword;
        private System.Windows.Forms.Label validatecPasword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label validateCaptcha;
        private System.Windows.Forms.Label strengthcheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox CPassword;
        private System.Windows.Forms.TextBox captchabox;
        private System.Windows.Forms.Button RefreshCaptcha;
    }
}