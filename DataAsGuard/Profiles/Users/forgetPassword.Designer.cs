namespace DataAsGuard.Profiles.Users
{
    partial class forgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgetPassword));
            this.RefreshCaptcha = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.cPassword = new System.Windows.Forms.TextBox();
            this.captchabox = new System.Windows.Forms.TextBox();
            this.validatePassword = new System.Windows.Forms.Label();
            this.validatecPasword = new System.Windows.Forms.Label();
            this.validateCaptcha = new System.Windows.Forms.Label();
            this.strengthcheck = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshCaptcha
            // 
            resources.ApplyResources(this.RefreshCaptcha, "RefreshCaptcha");
            this.RefreshCaptcha.Name = "RefreshCaptcha";
            this.RefreshCaptcha.UseVisualStyleBackColor = true;
            this.RefreshCaptcha.Click += new System.EventHandler(this.RefreshCaptcha_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.captchabox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.validatecPasword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.validateCaptcha, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.password, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.validatePassword, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.strengthcheck, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.TextChanged += new System.EventHandler(this.password_onleave);
            // 
            // cPassword
            // 
            resources.ApplyResources(this.cPassword, "cPassword");
            this.cPassword.BackColor = System.Drawing.SystemColors.Window;
            this.cPassword.Name = "cPassword";
            this.cPassword.TextChanged += new System.EventHandler(this.cpassword_onleave);
            // 
            // captchabox
            // 
            resources.ApplyResources(this.captchabox, "captchabox");
            this.captchabox.Name = "captchabox";
            // 
            // validatePassword
            // 
            resources.ApplyResources(this.validatePassword, "validatePassword");
            this.validatePassword.Name = "validatePassword";
            // 
            // validatecPasword
            // 
            resources.ApplyResources(this.validatecPasword, "validatecPasword");
            this.validatecPasword.Name = "validatecPasword";
            // 
            // validateCaptcha
            // 
            resources.ApplyResources(this.validateCaptcha, "validateCaptcha");
            this.validateCaptcha.Name = "validateCaptcha";
            // 
            // strengthcheck
            // 
            resources.ApplyResources(this.strengthcheck, "strengthcheck");
            this.strengthcheck.Name = "strengthcheck";
            // 
            // Confirm
            // 
            resources.ApplyResources(this.Confirm, "Confirm");
            this.Confirm.Name = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // forgetPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshCaptcha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Confirm);
            this.Name = "forgetPassword";
            this.Shown += new System.EventHandler(this.ChangePassword_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshCaptcha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox cPassword;
        private System.Windows.Forms.TextBox captchabox;
        private System.Windows.Forms.Label validatePassword;
        private System.Windows.Forms.Label validatecPasword;
        private System.Windows.Forms.Label validateCaptcha;
        private System.Windows.Forms.Label strengthcheck;
        private System.Windows.Forms.Button Confirm;
    }
}