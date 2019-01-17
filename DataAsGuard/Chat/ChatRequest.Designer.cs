namespace DataAsGuard.Chat
{
    partial class ChatRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatRequest));
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(18, 178);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(56, 55);
            this.settingsButton.TabIndex = 23;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(18, 97);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(56, 55);
            this.ProfileButton.TabIndex = 22;
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(18, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 55);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(1126, 18);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 55);
            this.BackButton.TabIndex = 24;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "User List";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Search:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 20;
            this.userList.Location = new System.Drawing.Point(489, 159);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(554, 344);
            this.userList.TabIndex = 28;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 39);
            this.button2.TabIndex = 29;
            this.button2.Text = "Start Chat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(713, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Users";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ChatRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatRequest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChatRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}