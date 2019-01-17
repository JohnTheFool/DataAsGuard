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
            this.ChatArea = new System.Windows.Forms.ListBox();
            this.userList = new System.Windows.Forms.ListBox();
            this.ChatMessage = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.NewChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChatArea
            // 
            this.ChatArea.FormattingEnabled = true;
            this.ChatArea.ItemHeight = 20;
            this.ChatArea.Location = new System.Drawing.Point(377, 65);
            this.ChatArea.Name = "ChatArea";
            this.ChatArea.Size = new System.Drawing.Size(684, 364);
            this.ChatArea.TabIndex = 0;
            this.ChatArea.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(1028, 461);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(62, 37);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // NewChat
            // 
            this.NewChat.Location = new System.Drawing.Point(115, 525);
            this.NewChat.Name = "NewChat";
            this.NewChat.Size = new System.Drawing.Size(173, 28);
            this.NewChat.TabIndex = 4;
            this.NewChat.Text = "Find a user";
            this.NewChat.UseVisualStyleBackColor = true;
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
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 565);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewChat);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.ChatMessage);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.ChatArea);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ChatArea;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.TextBox ChatMessage;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button NewChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
    }
}