namespace DataAsGuard.Profiles.Users
{
    partial class forgetUsername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgetUsername));
            this.RefreshCaptcha = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.validateUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.captchabox = new System.Windows.Forms.TextBox();
            this.validateCaptcha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshCaptcha
            // 
            this.RefreshCaptcha.Location = new System.Drawing.Point(400, 454);
            this.RefreshCaptcha.Name = "RefreshCaptcha";
            this.RefreshCaptcha.Size = new System.Drawing.Size(131, 27);
            this.RefreshCaptcha.TabIndex = 24;
            this.RefreshCaptcha.Text = "Refresh Captcha";
            this.RefreshCaptcha.UseVisualStyleBackColor = true;
            this.RefreshCaptcha.Click += new System.EventHandler(this.RefreshCaptcha_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(221, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(519, 108);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Confirm Your Details. Any Issue Contact The Admin";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.89605F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.10395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Controls.Add(this.validateUsername, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.captchabox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.validateCaptcha, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.username, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(184, 207);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 159);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // validateUsername
            // 
            this.validateUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validateUsername.AutoSize = true;
            this.validateUsername.Location = new System.Drawing.Point(476, 23);
            this.validateUsername.Name = "validateUsername";
            this.validateUsername.Size = new System.Drawing.Size(122, 17);
            this.validateUsername.TabIndex = 42;
            this.validateUsername.Text = "validateUsername";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(37, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 61);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // captchabox
            // 
            this.captchabox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.captchabox.Location = new System.Drawing.Point(240, 99);
            this.captchabox.Margin = new System.Windows.Forms.Padding(4);
            this.captchabox.Name = "captchabox";
            this.captchabox.Size = new System.Drawing.Size(132, 23);
            this.captchabox.TabIndex = 19;
            // 
            // validateCaptcha
            // 
            this.validateCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.validateCaptcha.AutoSize = true;
            this.validateCaptcha.Location = new System.Drawing.Point(476, 102);
            this.validateCaptcha.Name = "validateCaptcha";
            this.validateCaptcha.Size = new System.Drawing.Size(109, 17);
            this.validateCaptcha.TabIndex = 23;
            this.validateCaptcha.Text = "validateCaptcha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.username.Location = new System.Drawing.Point(239, 20);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 23);
            this.username.TabIndex = 24;
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(419, 418);
            this.Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(100, 28);
            this.Confirm.TabIndex = 20;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // forgetUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.RefreshCaptcha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Confirm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "forgetUsername";
            this.Text = "forgetUsername";
            this.Shown += new System.EventHandler(this.forgetUsername_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshCaptcha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label validateUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox captchabox;
        private System.Windows.Forms.Label validateCaptcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button Confirm;
    }
}