namespace DataAsGuard.Profiles.Admin
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.filesList = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataFilesGrid = new System.Windows.Forms.DataGridView();
            this.filesFilter = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.accountList = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataAccountGrid = new System.Windows.Forms.DataGridView();
            this.accountFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.noOfAccounts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.logTypeList = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataLogGrid = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.removeIP = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.removeIPbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.authoriseIP = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.AddUser = new System.Windows.Forms.Button();
            this.AdminHome = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.dataAuthoriseIPGrid = new System.Windows.Forms.DataGridView();
            this.tabPage4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFilesGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLogGrid)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAuthoriseIPGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.filesList);
            this.tabPage4.Controls.Add(this.panel6);
            this.tabPage4.Controls.Add(this.filesFilter);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(764, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Files Management";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Search:";
            // 
            // filesList
            // 
            this.filesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filesList.FormattingEnabled = true;
            this.filesList.Items.AddRange(new object[] {
            "Filename",
            "FileOwner",
            "Fileownerid"});
            this.filesList.Location = new System.Drawing.Point(69, 28);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(132, 24);
            this.filesList.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataFilesGrid);
            this.panel6.Location = new System.Drawing.Point(26, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(713, 356);
            this.panel6.TabIndex = 6;
            // 
            // dataFilesGrid
            // 
            this.dataFilesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataFilesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFilesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFilesGrid.Location = new System.Drawing.Point(0, 0);
            this.dataFilesGrid.Name = "dataFilesGrid";
            this.dataFilesGrid.ReadOnly = true;
            this.dataFilesGrid.Size = new System.Drawing.Size(713, 356);
            this.dataFilesGrid.TabIndex = 0;
            this.dataFilesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFilesGrid_CellContentClick);
            // 
            // filesFilter
            // 
            this.filesFilter.Location = new System.Drawing.Point(300, 28);
            this.filesFilter.Margin = new System.Windows.Forms.Padding(4);
            this.filesFilter.Name = "filesFilter";
            this.filesFilter.Size = new System.Drawing.Size(132, 23);
            this.filesFilter.TabIndex = 5;
            this.filesFilter.TextChanged += new System.EventHandler(this.filesFilter_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 31);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "Filter";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.accountList);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.accountFilter);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(764, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AccountManagement";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search:";
            // 
            // accountList
            // 
            this.accountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountList.FormattingEnabled = true;
            this.accountList.Items.AddRange(new object[] {
            "Username",
            "Email",
            "FullName",
            "Contact"});
            this.accountList.Location = new System.Drawing.Point(69, 28);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(132, 24);
            this.accountList.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataAccountGrid);
            this.panel5.Location = new System.Drawing.Point(26, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(713, 356);
            this.panel5.TabIndex = 5;
            // 
            // dataAccountGrid
            // 
            this.dataAccountGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataAccountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccountGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAccountGrid.Location = new System.Drawing.Point(0, 0);
            this.dataAccountGrid.Name = "dataAccountGrid";
            this.dataAccountGrid.ReadOnly = true;
            this.dataAccountGrid.Size = new System.Drawing.Size(713, 356);
            this.dataAccountGrid.TabIndex = 0;
            this.dataAccountGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAccountGrid_CellContentClick);
            // 
            // accountFilter
            // 
            this.accountFilter.Location = new System.Drawing.Point(299, 29);
            this.accountFilter.Margin = new System.Windows.Forms.Padding(4);
            this.accountFilter.Name = "accountFilter";
            this.accountFilter.Size = new System.Drawing.Size(132, 23);
            this.accountFilter.TabIndex = 2;
            this.accountFilter.TextChanged += new System.EventHandler(this.accountFilter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filter";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(764, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(435, 239);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 176);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of General Logs";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(23, 239);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 176);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number oF Suspicious Activity";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(435, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 178);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.noOfAccounts, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 150);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of accounts:";
            // 
            // noOfAccounts
            // 
            this.noOfAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noOfAccounts.AutoSize = true;
            this.noOfAccounts.Location = new System.Drawing.Point(147, 66);
            this.noOfAccounts.Name = "noOfAccounts";
            this.noOfAccounts.Size = new System.Drawing.Size(54, 17);
            this.noOfAccounts.TabIndex = 2;
            this.noOfAccounts.Text = "label27";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 178);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of File Created";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(60, 98);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 476);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.logTypeList);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(764, 447);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "General Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // logTypeList
            // 
            this.logTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logTypeList.FormattingEnabled = true;
            this.logTypeList.Items.AddRange(new object[] {
            "All",
            "LogonFailure",
            "LogonSuccess",
            "Registration",
            "Accounts",
            "Error"});
            this.logTypeList.Location = new System.Drawing.Point(69, 28);
            this.logTypeList.Name = "logTypeList";
            this.logTypeList.Size = new System.Drawing.Size(121, 24);
            this.logTypeList.TabIndex = 7;
            this.logTypeList.SelectedIndexChanged += new System.EventHandler(this.logsFilter_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataLogGrid);
            this.panel7.Location = new System.Drawing.Point(26, 58);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(713, 356);
            this.panel7.TabIndex = 6;
            // 
            // dataLogGrid
            // 
            this.dataLogGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLogGrid.Location = new System.Drawing.Point(0, 0);
            this.dataLogGrid.Name = "dataLogGrid";
            this.dataLogGrid.ReadOnly = true;
            this.dataLogGrid.Size = new System.Drawing.Size(713, 356);
            this.dataLogGrid.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(23, 31);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 17);
            this.label28.TabIndex = 3;
            this.label28.Text = "Filter";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel8);
            this.tabPage5.Controls.Add(this.removeIP);
            this.tabPage5.Controls.Add(this.tableLayoutPanel4);
            this.tabPage5.Controls.Add(this.authoriseIP);
            this.tabPage5.Controls.Add(this.tableLayoutPanel2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(764, 447);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Authorised IP Address";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataAuthoriseIPGrid);
            this.panel8.Location = new System.Drawing.Point(6, 124);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(752, 317);
            this.panel8.TabIndex = 7;
            // 
            // removeIP
            // 
            this.removeIP.Location = new System.Drawing.Point(663, 73);
            this.removeIP.Name = "removeIP";
            this.removeIP.Size = new System.Drawing.Size(95, 30);
            this.removeIP.TabIndex = 6;
            this.removeIP.Text = "Remove";
            this.removeIP.UseVisualStyleBackColor = true;
            this.removeIP.Click += new System.EventHandler(this.removeIP_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69697F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30303F));
            this.tableLayoutPanel4.Controls.Add(this.removeIPbox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(22, 65);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(635, 53);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // removeIPbox
            // 
            this.removeIPbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.removeIPbox.Location = new System.Drawing.Point(191, 15);
            this.removeIPbox.Name = "removeIPbox";
            this.removeIPbox.Size = new System.Drawing.Size(441, 23);
            this.removeIPbox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Remove IP:";
            // 
            // authoriseIP
            // 
            this.authoriseIP.Location = new System.Drawing.Point(663, 17);
            this.authoriseIP.Name = "authoriseIP";
            this.authoriseIP.Size = new System.Drawing.Size(95, 30);
            this.authoriseIP.TabIndex = 4;
            this.authoriseIP.Text = "Authorise";
            this.authoriseIP.UseVisualStyleBackColor = true;
            this.authoriseIP.Click += new System.EventHandler(this.authoriseIP_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69697F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30303F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ipBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(635, 53);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Authorise IP:";
            // 
            // ipBox
            // 
            this.ipBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipBox.Location = new System.Drawing.Point(191, 15);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(441, 23);
            this.ipBox.TabIndex = 1;
            // 
            // AddUser
            // 
            this.AddUser.Image = ((System.Drawing.Image)(resources.GetObject("AddUser.Image")));
            this.AddUser.Location = new System.Drawing.Point(819, 15);
            this.AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(52, 44);
            this.AddUser.TabIndex = 2;
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // AdminHome
            // 
            this.AdminHome.Image = ((System.Drawing.Image)(resources.GetObject("AdminHome.Image")));
            this.AdminHome.Location = new System.Drawing.Point(16, 15);
            this.AdminHome.Margin = new System.Windows.Forms.Padding(4);
            this.AdminHome.Name = "AdminHome";
            this.AdminHome.Size = new System.Drawing.Size(35, 42);
            this.AdminHome.TabIndex = 13;
            this.AdminHome.UseVisualStyleBackColor = true;
            this.AdminHome.Click += new System.EventHandler(this.AdminHome_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(819, 66);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(52, 50);
            this.Logout.TabIndex = 14;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(14, 66);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(37, 38);
            this.settingsButton.TabIndex = 18;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(74, 15);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(82, 42);
            this.changePassword.TabIndex = 19;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // dataAuthoriseIPGrid
            // 
            this.dataAuthoriseIPGrid.AllowUserToAddRows = false;
            this.dataAuthoriseIPGrid.AllowUserToDeleteRows = false;
            this.dataAuthoriseIPGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAuthoriseIPGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAuthoriseIPGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAuthoriseIPGrid.Location = new System.Drawing.Point(0, 0);
            this.dataAuthoriseIPGrid.Name = "dataAuthoriseIPGrid";
            this.dataAuthoriseIPGrid.ReadOnly = true;
            this.dataAuthoriseIPGrid.Size = new System.Drawing.Size(752, 317);
            this.dataAuthoriseIPGrid.TabIndex = 0;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.AdminHome);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.Load += new System.EventHandler(this.Adminprofile_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFilesGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLogGrid)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAuthoriseIPGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accountFilter;
        private System.Windows.Forms.TextBox filesFilter;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button AdminHome;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label noOfAccounts;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataAccountGrid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataFilesGrid;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataLogGrid;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox accountList;
        private System.Windows.Forms.ComboBox logTypeList;
        private System.Windows.Forms.ComboBox filesList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox removeIPbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button authoriseIP;
        private System.Windows.Forms.Button removeIP;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataAuthoriseIPGrid;
    }
}