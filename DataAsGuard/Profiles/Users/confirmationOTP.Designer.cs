namespace DataAsGuard.Profiles.Users
{
    partial class confirmationOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmationOTP));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.OTPInput = new System.Windows.Forms.TextBox();
            this.OTPConfirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshOTP = new System.Windows.Forms.Button();
            this.validationOTP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OTPInput, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(302, 231);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "OTP (One-Time Password):";
            // 
            // OTPInput
            // 
            this.OTPInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OTPInput.Location = new System.Drawing.Point(140, 15);
            this.OTPInput.Margin = new System.Windows.Forms.Padding(4);
            this.OTPInput.Name = "OTPInput";
            this.OTPInput.Size = new System.Drawing.Size(124, 23);
            this.OTPInput.TabIndex = 1;
            // 
            // OTPConfirm
            // 
            this.OTPConfirm.Location = new System.Drawing.Point(384, 349);
            this.OTPConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.OTPConfirm.Name = "OTPConfirm";
            this.OTPConfirm.Size = new System.Drawing.Size(100, 28);
            this.OTPConfirm.TabIndex = 1;
            this.OTPConfirm.Text = "Confirm";
            this.OTPConfirm.UseVisualStyleBackColor = true;
            this.OTPConfirm.Click += new System.EventHandler(this.OTPConfirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 107);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // refreshOTP
            // 
            this.refreshOTP.Location = new System.Drawing.Point(384, 384);
            this.refreshOTP.Name = "refreshOTP";
            this.refreshOTP.Size = new System.Drawing.Size(100, 28);
            this.refreshOTP.TabIndex = 3;
            this.refreshOTP.Text = "RefreshOTP";
            this.refreshOTP.UseVisualStyleBackColor = true;
            this.refreshOTP.Click += new System.EventHandler(this.refreshOTP_Click);
            // 
            // validationOTP
            // 
            this.validationOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validationOTP.AutoSize = true;
            this.validationOTP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.validationOTP.Location = new System.Drawing.Point(79, 12);
            this.validationOTP.Name = "validationOTP";
            this.validationOTP.Size = new System.Drawing.Size(97, 17);
            this.validationOTP.TabIndex = 4;
            this.validationOTP.Text = "validationOTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "A 5 digit OTP has been sent to your Phone Number.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.validationOTP);
            this.panel1.Location = new System.Drawing.Point(302, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 38);
            this.panel1.TabIndex = 6;
            // 
            // confirmationOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshOTP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OTPConfirm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "confirmationOTP";
            this.Text = "confirmationOTP";
            this.Shown += new System.EventHandler(this.OTP_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OTPInput;
        private System.Windows.Forms.Button OTPConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button refreshOTP;
        private System.Windows.Forms.Label validationOTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}