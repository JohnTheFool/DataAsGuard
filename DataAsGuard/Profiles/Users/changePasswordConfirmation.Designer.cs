namespace DataAsGuard.Profiles.Users
{
    partial class changePasswordConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePasswordConfirmation));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.cPassword = new System.Windows.Forms.TextBox();
            this.captchabox = new System.Windows.Forms.TextBox();
            this.validatePassword = new System.Windows.Forms.Label();
            this.validatecPasword = new System.Windows.Forms.Label();
            this.strengthcheck = new System.Windows.Forms.Label();
            this.validateCaptcha = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(183, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(524, 88);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.84018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.15982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.password, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.captchabox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.validatePassword, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.validatecPasword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.validateCaptcha, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.strengthcheck, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(137, 110);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 248);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(5, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 76);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Confirm Password";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password.Location = new System.Drawing.Point(238, 15);
            this.password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(116, 23);
            this.password.TabIndex = 15;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // cPassword
            // 
            this.cPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cPassword.BackColor = System.Drawing.SystemColors.Window;
            this.cPassword.Location = new System.Drawing.Point(238, 96);
            this.cPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cPassword.Name = "cPassword";
            this.cPassword.PasswordChar = '*';
            this.cPassword.Size = new System.Drawing.Size(116, 23);
            this.cPassword.TabIndex = 16;
            this.cPassword.TextChanged += new System.EventHandler(this.cPassword_TextChanged);
            // 
            // captchabox
            // 
            this.captchabox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.captchabox.Location = new System.Drawing.Point(238, 180);
            this.captchabox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.captchabox.Name = "captchabox";
            this.captchabox.Size = new System.Drawing.Size(116, 23);
            this.captchabox.TabIndex = 19;
            // 
            // validatePassword
            // 
            this.validatePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validatePassword.AutoSize = true;
            this.validatePassword.Location = new System.Drawing.Point(363, 18);
            this.validatePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validatePassword.Name = "validatePassword";
            this.validatePassword.Size = new System.Drawing.Size(118, 17);
            this.validatePassword.TabIndex = 20;
            this.validatePassword.Text = "validatePassword";
            // 
            // validatecPasword
            // 
            this.validatecPasword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validatecPasword.AutoSize = true;
            this.validatecPasword.Location = new System.Drawing.Point(363, 99);
            this.validatecPasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validatecPasword.Name = "validatecPasword";
            this.validatecPasword.Size = new System.Drawing.Size(127, 17);
            this.validatecPasword.TabIndex = 21;
            this.validatecPasword.Text = "validateCPassword";
            // 
            // strengthcheck
            // 
            this.strengthcheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.strengthcheck.AutoSize = true;
            this.strengthcheck.Location = new System.Drawing.Point(266, 54);
            this.strengthcheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strengthcheck.Name = "strengthcheck";
            this.strengthcheck.Size = new System.Drawing.Size(60, 17);
            this.strengthcheck.TabIndex = 22;
            this.strengthcheck.Text = "strength";
            // 
            // validateCaptcha
            // 
            this.validateCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validateCaptcha.AutoSize = true;
            this.validateCaptcha.Location = new System.Drawing.Point(363, 183);
            this.validateCaptcha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validateCaptcha.Name = "validateCaptcha";
            this.validateCaptcha.Size = new System.Drawing.Size(109, 17);
            this.validateCaptcha.TabIndex = 23;
            this.validateCaptcha.Text = "validateCaptcha";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(358, 368);
            this.Confirm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(133, 34);
            this.Confirm.TabIndex = 19;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // changePasswordConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Confirm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "changePasswordConfirmation";
            this.Text = "changePasswordConfirmation";
            this.Shown += new System.EventHandler(this.ChangePassword_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox cPassword;
        private System.Windows.Forms.TextBox captchabox;
        private System.Windows.Forms.Label validatePassword;
        private System.Windows.Forms.Label validatecPasword;
        private System.Windows.Forms.Label strengthcheck;
        private System.Windows.Forms.Label validateCaptcha;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label5;
    }
}