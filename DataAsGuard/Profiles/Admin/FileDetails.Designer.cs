namespace DataAsGuard.Profiles.Admin
{
    partial class FileDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDetails));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fileSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fileLock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.description = new System.Windows.Forms.Label();
            this.dateCreated = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fileOwner = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileOwnerid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datalogGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Lockbtn = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.AdminHome = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalogGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fileSize, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileLock, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fileID, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(592, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 116);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // fileSize
            // 
            this.fileSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileSize.AutoSize = true;
            this.fileSize.Location = new System.Drawing.Point(140, 50);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(57, 17);
            this.fileSize.TabIndex = 15;
            this.fileSize.Text = "FileSize";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lock";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "File ID:";
            // 
            // fileLock
            // 
            this.fileLock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileLock.AutoSize = true;
            this.fileLock.Location = new System.Drawing.Point(140, 88);
            this.fileLock.Name = "fileLock";
            this.fileLock.Size = new System.Drawing.Size(38, 17);
            this.fileLock.TabIndex = 11;
            this.fileLock.Text = "Lock";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "FileSize";
            // 
            // fileID
            // 
            this.fileID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileID.AutoSize = true;
            this.fileID.Location = new System.Drawing.Point(140, 11);
            this.fileID.Name = "fileID";
            this.fileID.Size = new System.Drawing.Size(37, 17);
            this.fileID.TabIndex = 13;
            this.fileID.Text = "fileid";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.04663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.95337F));
            this.tableLayoutPanel1.Controls.Add(this.description, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateCreated, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fileOwner, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fileOwnerid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.filename, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(91, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.09836F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.90164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 195);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(168, 151);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(87, 18);
            this.description.TabIndex = 9;
            this.description.Text = "Description:";
            // 
            // dateCreated
            // 
            this.dateCreated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateCreated.AutoSize = true;
            this.dateCreated.Location = new System.Drawing.Point(168, 98);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(88, 18);
            this.dateCreated.TabIndex = 7;
            this.dateCreated.Text = "dateCreated";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date Created:";
            // 
            // fileOwner
            // 
            this.fileOwner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileOwner.AutoSize = true;
            this.fileOwner.Location = new System.Drawing.Point(168, 66);
            this.fileOwner.Name = "fileOwner";
            this.fileOwner.Size = new System.Drawing.Size(70, 18);
            this.fileOwner.TabIndex = 5;
            this.fileOwner.Text = "fileOwner";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "File Owner:";
            // 
            // fileOwnerid
            // 
            this.fileOwnerid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileOwnerid.AutoSize = true;
            this.fileOwnerid.Location = new System.Drawing.Point(168, 38);
            this.fileOwnerid.Name = "fileOwnerid";
            this.fileOwnerid.Size = new System.Drawing.Size(84, 18);
            this.fileOwnerid.TabIndex = 3;
            this.fileOwnerid.Text = "fileOwnerID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "File Owner ID:";
            // 
            // filename
            // 
            this.filename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(168, 7);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(63, 18);
            this.filename.TabIndex = 1;
            this.filename.Text = "filename";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(69, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 275);
            this.panel1.TabIndex = 35;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 266);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datalogGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // datalogGrid
            // 
            this.datalogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datalogGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datalogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalogGrid.Location = new System.Drawing.Point(3, 3);
            this.datalogGrid.Name = "datalogGrid";
            this.datalogGrid.ReadOnly = true;
            this.datalogGrid.Size = new System.Drawing.Size(821, 231);
            this.datalogGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Access";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Lockbtn
            // 
            this.Lockbtn.Location = new System.Drawing.Point(692, 200);
            this.Lockbtn.Name = "Lockbtn";
            this.Lockbtn.Size = new System.Drawing.Size(75, 43);
            this.Lockbtn.TabIndex = 29;
            this.Lockbtn.Text = "Lock";
            this.Lockbtn.UseVisualStyleBackColor = true;
            this.Lockbtn.Click += new System.EventHandler(this.Lockbtn_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(919, 64);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(52, 50);
            this.Logout.TabIndex = 32;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AdminHome
            // 
            this.AdminHome.Image = ((System.Drawing.Image)(resources.GetObject("AdminHome.Image")));
            this.AdminHome.Location = new System.Drawing.Point(11, 12);
            this.AdminHome.Margin = new System.Windows.Forms.Padding(4);
            this.AdminHome.Name = "AdminHome";
            this.AdminHome.Size = new System.Drawing.Size(35, 42);
            this.AdminHome.TabIndex = 31;
            this.AdminHome.UseVisualStyleBackColor = true;
            this.AdminHome.Click += new System.EventHandler(this.AdminHome_Click);
            // 
            // AddUser
            // 
            this.AddUser.Image = ((System.Drawing.Image)(resources.GetObject("AddUser.Image")));
            this.AddUser.Location = new System.Drawing.Point(919, 13);
            this.AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(52, 44);
            this.AddUser.TabIndex = 30;
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(9, 63);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 38);
            this.settingsButton.TabIndex = 33;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // FileDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lockbtn);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.AdminHome);
            this.Controls.Add(this.AddUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileDetails";
            this.Text = "FileDetails";
            this.Shown += new System.EventHandler(this.fileDetails_Shown);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalogGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label fileID;
        private System.Windows.Forms.Label fileLock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dateCreated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fileOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fileOwnerid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView datalogGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Lockbtn;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AdminHome;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fileSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button settingsButton;
    }
}