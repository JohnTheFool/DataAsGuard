namespace DataAsGuard.Profiles.Admin
{
    partial class RegistrationDetails
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.phoneNo = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.captchabox = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOB (DD/MM/YYYY)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number(No.)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // DOB
            // 
            this.DOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(216, 199);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(111, 13);
            this.DOB.TabIndex = 12;
            this.DOB.Text = "DOB (DD/MM/YYYY)";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(216, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 9;
            this.name.Text = "Name:";
            // 
            // phoneNo
            // 
            this.phoneNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneNo.AutoSize = true;
            this.phoneNo.Location = new System.Drawing.Point(216, 109);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(101, 13);
            this.phoneNo.TabIndex = 11;
            this.phoneNo.Text = "Phone Number(No.)";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(216, 62);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 10;
            this.email.Text = "Email";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.phoneNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.email, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.captchabox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DOB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fName, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 326);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(3, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 65);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // captchabox
            // 
            this.captchabox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.captchabox.BackColor = System.Drawing.SystemColors.Window;
            this.captchabox.Location = new System.Drawing.Point(216, 267);
            this.captchabox.Name = "captchabox";
            this.captchabox.Size = new System.Drawing.Size(100, 20);
            this.captchabox.TabIndex = 14;
            // 
            // Confirm
            // 
            this.Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Confirm.Location = new System.Drawing.Point(351, 365);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 15;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "FullName";
            // 
            // fName
            // 
            this.fName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(216, 155);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(48, 13);
            this.fName.TabIndex = 16;
            this.fName.Text = "fullName";
            // 
            // RegistrationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegistrationDetails";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label phoneNo;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox captchabox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fName;
    }
}