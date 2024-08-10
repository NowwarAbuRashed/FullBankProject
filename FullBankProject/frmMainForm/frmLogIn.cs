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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
         
                if (clsUser.ChickUserNameAndPassowrd(txtUserName.Text,txtPassword.Text))
                {

                clsLoginRegisters.AddLoginRegisters(clsGlobal.UserLogIn.PersonID,DateTime.Now);

                this.Visible = false;
                frmStartBank StartBank = new frmStartBank();
                StartBank.ShowDialog();
                this.Visible = true;
                txtUserName.Text = "User Name";
                txtPassword.Text = "Password";

            }
                else
            {
                MessageBox.Show("Wrong Please enter UserName And Passowrd Correct","Wrong");
            }
            
            

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            

        }
    }
}
