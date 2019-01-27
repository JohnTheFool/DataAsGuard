namespace DataAsGuard.Chat
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.userList = new System.Windows.Forms.ListBox();
            this.ChatMessage = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.NewChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 20;
            this.userList.Location = new System.Drawing.Point(115, 65);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(173, 444);
            this.userList.TabIndex = 1;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // ChatMessage
            // 
            this.ChatMessage.Location = new System.Drawing.Point(377, 452);
            this.ChatMessage.Multiline = true;
            this.ChatMessage.Name = "ChatMessage";
            this.ChatMessage.Size = new System.Drawing.Size(636, 57);
            this.ChatMessage.TabIndex = 2;
            this.ChatMessage.TextChanged += new System.EventHandler(this.ChatMessage_TextChanged);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(1019, 461);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(66, 41);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // NewChat
            // 
            this.NewChat.Location = new System.Drawing.Point(115, 516);
            this.NewChat.Name = "NewChat";
            this.NewChat.Size = new System.Drawing.Size(173, 37);
            this.NewChat.TabIndex = 4;
            this.NewChat.Text = "Find a user";
            this.NewChat.UseVisualStyleBackColor = true;
            this.NewChat.Click += new System.EventHandler(this.NewChat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(382, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 20);
            this.username.TabIndex = 6;
            this.username.Text = "userName";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(377, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(636, 381);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(13, 187);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(56, 55);
            this.settingsButton.TabIndex = 26;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(13, 106);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(56, 55);
            this.ProfileButton.TabIndex = 25;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(13, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 55);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(1061, 27);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 55);
            this.BackButton.TabIndex = 27;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(962, 516);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(98, 20);
            this.Counter.TabIndex = 28;
            this.Counter.Text = "Word Count:";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 565);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewChat);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.ChatMessage);
            this.Controls.Add(this.userList);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.TextBox ChatMessage;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button NewChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Counter;
    }
}