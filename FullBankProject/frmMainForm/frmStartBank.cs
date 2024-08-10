using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullBankProject
{
    public partial class frmStartBank : Form
    {

        enum enPermissions
        {
            ClientList = 1,
            AddNewClient = 2,
            DeleteClient = 4,
            UpdateClient = 8,
            FindClient = 16,
            Transactions = 32,
            ManageUsers = 64,
            CurrencyExchange = 128
        }

        public frmStartBank()
        {
            InitializeComponent();
            coustomizeDesing();
            lblUserlogin.Text = clsGlobal.UserLogIn.UserName;
            InitializeTimer();
        }
        private Timer timer;
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // تحديث كل ثانية
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd         HH:mm:ss");
        }
        private void coustomizeDesing()
        {
            panelCliantSubMenu.Visible = false;
            panelCurrencyExchangeSubMenu.Visible = false;
            panelTransactionsSubMenu.Visible = false;
            panelUsersSubMenu.Visible = false;

        }
        private void hideSunMenu()
        {
            if (panelCliantSubMenu.Visible == true)
                panelCliantSubMenu.Visible = false;
            if(panelCurrencyExchangeSubMenu.Visible== true)
                panelCurrencyExchangeSubMenu.Visible = false;
            if(panelTransactionsSubMenu.Visible== true)
                panelTransactionsSubMenu.Visible = false;
            if( panelUsersSubMenu.Visible== true)
                panelUsersSubMenu.Visible = false;
        }
        private  void showSunMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSunMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private bool ISPermission(int UsrePermission, int Permission)
        {
               
                if ((UsrePermission & Permission) > 0) 
                {
                    return true;
                }
            return false;
        }
        private void btnCliant_Click(object sender, EventArgs e)
        {
            showSunMenu(panelCliantSubMenu);
        }

        #region CliantSubMenu
        private void btnAddCliant_Click(object sender, EventArgs e)
        {
            if (ISPermission(clsGlobal.UserLogIn.Permissions,Convert.ToInt32(enPermissions.AddNewClient)))
            {
                _OpenChildForm(new frmAddCliant());
            }
            else
            {
                MessageBox.Show("You Can not Enrol this", "No Permission");
            }
            hideSunMenu();
        }

        private void btnUpdateCliant_Click(object sender, EventArgs e)
        {
            if (ISPermission(clsGlobal.UserLogIn.Permissions, Convert.ToInt32(enPermissions.UpdateClient)))
            {
                _OpenChildForm(new frmUpdateCliant());
            }
            else
            {
                MessageBox.Show("You Can not Enrol this", "No Permission");
            }
            
            //
            // Your Code
            //

            hideSunMenu();
        }

        private void btnDeleteCliant_Click(object sender, EventArgs e)
        {

            if (ISPermission(clsGlobal.UserLogIn.Permissions, Convert.ToInt32(enPermissions.DeleteClient)))
            {
                _OpenChildForm(new frmDeleteCliant());
            }
            else
            {
                MessageBox.Show("You Can not Enrol this", "No Permission");
            }

           
            //
            // Your Code
            //

            hideSunMenu();
        }

        private void btnFindCliant_Click(object sender, EventArgs e)
        {
            if (ISPermission(clsGlobal.UserLogIn.Permissions, Convert.ToInt32(enPermissions.FindClient)))
            {
                _OpenChildForm(new frmFindCliant());
            }
            else
            {
                MessageBox.Show("You Can not Enrol this", "No Permission");
            }
           
            //
            // Your Code
            //

            hideSunMenu();
        }

        private void btnShowClientList_Click(object sender, EventArgs e)
        {
            if (ISPermission(clsGlobal.UserLogIn.Permissions, Convert.ToInt32(enPermissions.ClientList)))
            {
                _OpenChildForm(new frmShowClientList());
            }
            else
            {
                MessageBox.Show("You Can not Enrol this", "No Permission");
            }
            
            //
            // Your Code
            //

            hideSunMenu();
        }
#endregion
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (ISPermission(clsGlobal.UserLogIn.Permissions, Convert.ToInt32(enPermissions.Transactions)))
            {
                showSunMenu(panelTransactionsSubMenu);
            }
            else
            {
                MessageBox.Show("You Can not Enrol this", "No Permission");
            }
           
        }

        #region TransactionsSubMenu

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmDeposit());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmWithdraw());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmTransfer());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmTransferLog());
            //
            // Your Code
            //

            hideSunMenu();

        }
#endregion

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (ISPermission(clsGlobal.UserLogIn.Permissions, Convert.ToInt32(enPermissions.ManageUsers)))
            {
                showSunMenu(panelUsersSubMenu);
            }
            else
            {
                MessageBox.Show("You Can not Enrol this", "No Permission");
            }
           
        }

        #region  UsersSubMenu
        private void btnListUser_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmListUser());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmAddUser());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmUpdateUser());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmDeleteUser());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmFindUser());
            //
            // Your Code
            //

            hideSunMenu();

        }

#endregion

      
        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            if (ISPermission(clsGlobal.UserLogIn.Permissions, Convert.ToInt32(enPermissions.CurrencyExchange)))
            {
                showSunMenu(panelCurrencyExchangeSubMenu);
            }
            else
            {
                MessageBox.Show("You Can not Enrol this", "No Permission");
            }
            
        }

        #region  CurrencyExchangeSubMenu
        private void btnListCurrencies_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmListCurrencies());
            //
            // Your Code
            //

            hideSunMenu();

        }
        private void btnFindCurrencies_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmFindCurrencies());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmUpdateRate());
            //
            // Your Code
            //

            hideSunMenu();

        }

        private void btnCurrencyCalculator_Click(object sender, EventArgs e)
        {
            _OpenChildForm(new frmCurrencyCalculater());
            //
            // Your Code
            //

            hideSunMenu();

        }
#endregion


        private Form _ActiveForm=null;
        private void _OpenChildForm(Form ChildForm)
        {
            if(_ActiveForm!=null)
                _ActiveForm.Close();
            _ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle= FormBorderStyle.None;
            ChildForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag= ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }

        private void frmStartBank_Load(object sender, EventArgs e)
        {

        }
    }
}
