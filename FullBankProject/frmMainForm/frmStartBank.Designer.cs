namespace FullBankProject
{
    partial class frmStartBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartBank));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelCurrencyExchangeSubMenu = new System.Windows.Forms.Panel();
            this.btnCurrencyCalculator = new System.Windows.Forms.Button();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.btnFindCurrencies = new System.Windows.Forms.Button();
            this.btnListCurrencies = new System.Windows.Forms.Button();
            this.btnCurrencyExchange = new System.Windows.Forms.Button();
            this.panelUsersSubMenu = new System.Windows.Forms.Panel();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnListUser = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelTransactionsSubMenu = new System.Windows.Forms.Panel();
            this.btnTransferLog = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.panelCliantSubMenu = new System.Windows.Forms.Panel();
            this.btnShowClientList = new System.Windows.Forms.Button();
            this.btnFindCliant = new System.Windows.Forms.Button();
            this.btnDeleteCliant = new System.Windows.Forms.Button();
            this.btnUpdateCliant = new System.Windows.Forms.Button();
            this.btnAddCliant = new System.Windows.Forms.Button();
            this.btnCliant = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserlogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelCurrencyExchangeSubMenu.SuspendLayout();
            this.panelUsersSubMenu.SuspendLayout();
            this.panelTransactionsSubMenu.SuspendLayout();
            this.panelCliantSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.panelSideMenu.Controls.Add(this.panelCurrencyExchangeSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCurrencyExchange);
            this.panelSideMenu.Controls.Add(this.panelUsersSubMenu);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Controls.Add(this.panelTransactionsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTransactions);
            this.panelSideMenu.Controls.Add(this.panelCliantSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCliant);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelCurrencyExchangeSubMenu
            // 
            this.panelCurrencyExchangeSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCurrencyExchangeSubMenu.Controls.Add(this.btnCurrencyCalculator);
            this.panelCurrencyExchangeSubMenu.Controls.Add(this.btnUpdateRate);
            this.panelCurrencyExchangeSubMenu.Controls.Add(this.btnFindCurrencies);
            this.panelCurrencyExchangeSubMenu.Controls.Add(this.btnListCurrencies);
            this.panelCurrencyExchangeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrencyExchangeSubMenu.Location = new System.Drawing.Point(0, 869);
            this.panelCurrencyExchangeSubMenu.Name = "panelCurrencyExchangeSubMenu";
            this.panelCurrencyExchangeSubMenu.Size = new System.Drawing.Size(229, 165);
            this.panelCurrencyExchangeSubMenu.TabIndex = 8;
            // 
            // btnCurrencyCalculator
            // 
            this.btnCurrencyCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrencyCalculator.FlatAppearance.BorderSize = 0;
            this.btnCurrencyCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencyCalculator.ForeColor = System.Drawing.Color.LightGray;
            this.btnCurrencyCalculator.Location = new System.Drawing.Point(0, 120);
            this.btnCurrencyCalculator.Name = "btnCurrencyCalculator";
            this.btnCurrencyCalculator.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCurrencyCalculator.Size = new System.Drawing.Size(229, 40);
            this.btnCurrencyCalculator.TabIndex = 3;
            this.btnCurrencyCalculator.Text = "Currency Calculator";
            this.btnCurrencyCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrencyCalculator.UseVisualStyleBackColor = true;
            this.btnCurrencyCalculator.Click += new System.EventHandler(this.btnCurrencyCalculator_Click);
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateRate.FlatAppearance.BorderSize = 0;
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.ForeColor = System.Drawing.Color.LightGray;
            this.btnUpdateRate.Location = new System.Drawing.Point(0, 80);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateRate.Size = new System.Drawing.Size(229, 40);
            this.btnUpdateRate.TabIndex = 2;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRate.UseVisualStyleBackColor = true;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // btnFindCurrencies
            // 
            this.btnFindCurrencies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindCurrencies.FlatAppearance.BorderSize = 0;
            this.btnFindCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCurrencies.ForeColor = System.Drawing.Color.LightGray;
            this.btnFindCurrencies.Location = new System.Drawing.Point(0, 40);
            this.btnFindCurrencies.Name = "btnFindCurrencies";
            this.btnFindCurrencies.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFindCurrencies.Size = new System.Drawing.Size(229, 40);
            this.btnFindCurrencies.TabIndex = 1;
            this.btnFindCurrencies.Text = "Find Currencies";
            this.btnFindCurrencies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCurrencies.UseVisualStyleBackColor = true;
            this.btnFindCurrencies.Click += new System.EventHandler(this.btnFindCurrencies_Click);
            // 
            // btnListCurrencies
            // 
            this.btnListCurrencies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListCurrencies.FlatAppearance.BorderSize = 0;
            this.btnListCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCurrencies.ForeColor = System.Drawing.Color.LightGray;
            this.btnListCurrencies.Location = new System.Drawing.Point(0, 0);
            this.btnListCurrencies.Name = "btnListCurrencies";
            this.btnListCurrencies.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListCurrencies.Size = new System.Drawing.Size(229, 40);
            this.btnListCurrencies.TabIndex = 0;
            this.btnListCurrencies.Text = "List Currencies";
            this.btnListCurrencies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListCurrencies.UseVisualStyleBackColor = true;
            this.btnListCurrencies.Click += new System.EventHandler(this.btnListCurrencies_Click);
            // 
            // btnCurrencyExchange
            // 
            this.btnCurrencyExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrencyExchange.FlatAppearance.BorderSize = 0;
            this.btnCurrencyExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencyExchange.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCurrencyExchange.Location = new System.Drawing.Point(0, 824);
            this.btnCurrencyExchange.Name = "btnCurrencyExchange";
            this.btnCurrencyExchange.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCurrencyExchange.Size = new System.Drawing.Size(229, 45);
            this.btnCurrencyExchange.TabIndex = 7;
            this.btnCurrencyExchange.Text = "Currency Exchange";
            this.btnCurrencyExchange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrencyExchange.UseVisualStyleBackColor = true;
            this.btnCurrencyExchange.Click += new System.EventHandler(this.btnCurrencyExchange_Click);
            // 
            // panelUsersSubMenu
            // 
            this.panelUsersSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelUsersSubMenu.Controls.Add(this.btnFindUser);
            this.panelUsersSubMenu.Controls.Add(this.btnDeleteUser);
            this.panelUsersSubMenu.Controls.Add(this.btnUpdateUser);
            this.panelUsersSubMenu.Controls.Add(this.btnAddUser);
            this.panelUsersSubMenu.Controls.Add(this.btnListUser);
            this.panelUsersSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersSubMenu.Location = new System.Drawing.Point(0, 611);
            this.panelUsersSubMenu.Name = "panelUsersSubMenu";
            this.panelUsersSubMenu.Size = new System.Drawing.Size(229, 213);
            this.panelUsersSubMenu.TabIndex = 6;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.ForeColor = System.Drawing.Color.LightGray;
            this.btnFindUser.Location = new System.Drawing.Point(0, 160);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFindUser.Size = new System.Drawing.Size(229, 40);
            this.btnFindUser.TabIndex = 4;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 120);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(229, 40);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.LightGray;
            this.btnUpdateUser.Location = new System.Drawing.Point(0, 80);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(229, 40);
            this.btnUpdateUser.TabIndex = 2;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddUser.Location = new System.Drawing.Point(0, 40);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(229, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnListUser
            // 
            this.btnListUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListUser.FlatAppearance.BorderSize = 0;
            this.btnListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUser.ForeColor = System.Drawing.Color.LightGray;
            this.btnListUser.Location = new System.Drawing.Point(0, 0);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListUser.Size = new System.Drawing.Size(229, 40);
            this.btnListUser.TabIndex = 0;
            this.btnListUser.Text = "List User";
            this.btnListUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUser.UseVisualStyleBackColor = true;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.Location = new System.Drawing.Point(0, 566);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(229, 45);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelTransactionsSubMenu
            // 
            this.panelTransactionsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelTransactionsSubMenu.Controls.Add(this.btnTransferLog);
            this.panelTransactionsSubMenu.Controls.Add(this.btnTransfer);
            this.panelTransactionsSubMenu.Controls.Add(this.btnWithdraw);
            this.panelTransactionsSubMenu.Controls.Add(this.btnDeposit);
            this.panelTransactionsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransactionsSubMenu.Location = new System.Drawing.Point(0, 401);
            this.panelTransactionsSubMenu.Name = "panelTransactionsSubMenu";
            this.panelTransactionsSubMenu.Size = new System.Drawing.Size(229, 165);
            this.panelTransactionsSubMenu.TabIndex = 4;
            // 
            // btnTransferLog
            // 
            this.btnTransferLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransferLog.FlatAppearance.BorderSize = 0;
            this.btnTransferLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferLog.ForeColor = System.Drawing.Color.LightGray;
            this.btnTransferLog.Location = new System.Drawing.Point(0, 120);
            this.btnTransferLog.Name = "btnTransferLog";
            this.btnTransferLog.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTransferLog.Size = new System.Drawing.Size(229, 40);
            this.btnTransferLog.TabIndex = 3;
            this.btnTransferLog.Text = "Transfer Log";
            this.btnTransferLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransferLog.UseVisualStyleBackColor = true;
            this.btnTransferLog.Click += new System.EventHandler(this.btnTransferLog_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.LightGray;
            this.btnTransfer.Location = new System.Drawing.Point(0, 80);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(229, 40);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.ForeColor = System.Drawing.Color.LightGray;
            this.btnWithdraw.Location = new System.Drawing.Point(0, 40);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(229, 40);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeposit.Location = new System.Drawing.Point(0, 0);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeposit.Size = new System.Drawing.Size(229, 40);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransactions.Location = new System.Drawing.Point(0, 356);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransactions.Size = new System.Drawing.Size(229, 45);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // panelCliantSubMenu
            // 
            this.panelCliantSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCliantSubMenu.Controls.Add(this.btnShowClientList);
            this.panelCliantSubMenu.Controls.Add(this.btnFindCliant);
            this.panelCliantSubMenu.Controls.Add(this.btnDeleteCliant);
            this.panelCliantSubMenu.Controls.Add(this.btnUpdateCliant);
            this.panelCliantSubMenu.Controls.Add(this.btnAddCliant);
            this.panelCliantSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCliantSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelCliantSubMenu.Name = "panelCliantSubMenu";
            this.panelCliantSubMenu.Size = new System.Drawing.Size(229, 211);
            this.panelCliantSubMenu.TabIndex = 2;
            // 
            // btnShowClientList
            // 
            this.btnShowClientList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowClientList.FlatAppearance.BorderSize = 0;
            this.btnShowClientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowClientList.ForeColor = System.Drawing.Color.LightGray;
            this.btnShowClientList.Location = new System.Drawing.Point(0, 160);
            this.btnShowClientList.Name = "btnShowClientList";
            this.btnShowClientList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShowClientList.Size = new System.Drawing.Size(229, 40);
            this.btnShowClientList.TabIndex = 4;
            this.btnShowClientList.Text = "Show Client List";
            this.btnShowClientList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowClientList.UseVisualStyleBackColor = true;
            this.btnShowClientList.Click += new System.EventHandler(this.btnShowClientList_Click);
            // 
            // btnFindCliant
            // 
            this.btnFindCliant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindCliant.FlatAppearance.BorderSize = 0;
            this.btnFindCliant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCliant.ForeColor = System.Drawing.Color.LightGray;
            this.btnFindCliant.Location = new System.Drawing.Point(0, 120);
            this.btnFindCliant.Name = "btnFindCliant";
            this.btnFindCliant.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFindCliant.Size = new System.Drawing.Size(229, 40);
            this.btnFindCliant.TabIndex = 3;
            this.btnFindCliant.Text = "Find Cliant";
            this.btnFindCliant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCliant.UseVisualStyleBackColor = true;
            this.btnFindCliant.Click += new System.EventHandler(this.btnFindCliant_Click);
            // 
            // btnDeleteCliant
            // 
            this.btnDeleteCliant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteCliant.FlatAppearance.BorderSize = 0;
            this.btnDeleteCliant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCliant.ForeColor = System.Drawing.Color.LightGray;
            this.btnDeleteCliant.Location = new System.Drawing.Point(0, 80);
            this.btnDeleteCliant.Name = "btnDeleteCliant";
            this.btnDeleteCliant.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeleteCliant.Size = new System.Drawing.Size(229, 40);
            this.btnDeleteCliant.TabIndex = 2;
            this.btnDeleteCliant.Text = "Delete Cliant";
            this.btnDeleteCliant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCliant.UseVisualStyleBackColor = true;
            this.btnDeleteCliant.Click += new System.EventHandler(this.btnDeleteCliant_Click);
            // 
            // btnUpdateCliant
            // 
            this.btnUpdateCliant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateCliant.FlatAppearance.BorderSize = 0;
            this.btnUpdateCliant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCliant.ForeColor = System.Drawing.Color.LightGray;
            this.btnUpdateCliant.Location = new System.Drawing.Point(0, 40);
            this.btnUpdateCliant.Name = "btnUpdateCliant";
            this.btnUpdateCliant.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateCliant.Size = new System.Drawing.Size(229, 40);
            this.btnUpdateCliant.TabIndex = 1;
            this.btnUpdateCliant.Text = "Update Cliant";
            this.btnUpdateCliant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCliant.UseVisualStyleBackColor = true;
            this.btnUpdateCliant.Click += new System.EventHandler(this.btnUpdateCliant_Click);
            // 
            // btnAddCliant
            // 
            this.btnAddCliant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCliant.FlatAppearance.BorderSize = 0;
            this.btnAddCliant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliant.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddCliant.Location = new System.Drawing.Point(0, 0);
            this.btnAddCliant.Name = "btnAddCliant";
            this.btnAddCliant.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddCliant.Size = new System.Drawing.Size(229, 40);
            this.btnAddCliant.TabIndex = 0;
            this.btnAddCliant.Text = "Add Cliant";
            this.btnAddCliant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCliant.UseVisualStyleBackColor = true;
            this.btnAddCliant.Click += new System.EventHandler(this.btnAddCliant_Click);
            // 
            // btnCliant
            // 
            this.btnCliant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliant.FlatAppearance.BorderSize = 0;
            this.btnCliant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliant.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCliant.Location = new System.Drawing.Point(0, 100);
            this.btnCliant.Name = "btnCliant";
            this.btnCliant.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCliant.Size = new System.Drawing.Size(229, 45);
            this.btnCliant.TabIndex = 1;
            this.btnCliant.Text = "Cliant";
            this.btnCliant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliant.UseVisualStyleBackColor = true;
            this.btnCliant.Click += new System.EventHandler(this.btnCliant_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblUserlogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 63);
            this.panel2.TabIndex = 2;
            // 
            // lblUserlogin
            // 
            this.lblUserlogin.AutoSize = true;
            this.lblUserlogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserlogin.Location = new System.Drawing.Point(556, 27);
            this.lblUserlogin.Name = "lblUserlogin";
            this.lblUserlogin.Size = new System.Drawing.Size(42, 21);
            this.lblUserlogin.TabIndex = 1;
            this.lblUserlogin.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(495, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User :";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Location = new System.Drawing.Point(250, 63);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(682, 490);
            this.panelChildForm.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(23, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 21);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "0:0:0";
            // 
            // frmStartBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frmStartBank";
            this.Text = "Start Bank";
            this.Load += new System.EventHandler(this.frmStartBank_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelCurrencyExchangeSubMenu.ResumeLayout(false);
            this.panelUsersSubMenu.ResumeLayout(false);
            this.panelTransactionsSubMenu.ResumeLayout(false);
            this.panelCliantSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCliant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCliantSubMenu;
        private System.Windows.Forms.Button btnAddCliant;
        private System.Windows.Forms.Button btnFindCliant;
        private System.Windows.Forms.Button btnDeleteCliant;
        private System.Windows.Forms.Button btnUpdateCliant;
        private System.Windows.Forms.Panel panelCurrencyExchangeSubMenu;
        private System.Windows.Forms.Button btnCurrencyCalculator;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.Button btnFindCurrencies;
        private System.Windows.Forms.Button btnListCurrencies;
        private System.Windows.Forms.Button btnCurrencyExchange;
        private System.Windows.Forms.Panel panelUsersSubMenu;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panelTransactionsSubMenu;
        private System.Windows.Forms.Button btnTransferLog;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnShowClientList;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
    }
}