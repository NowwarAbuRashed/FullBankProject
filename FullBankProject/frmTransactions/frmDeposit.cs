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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(Convert.ToInt32(txtAccountBalance.Text));

            if (client != null)
            {
                clsPerson person = clsPerson.Find(client.PersonID);
                if (person != null)
                {
                    txtFirstName.Text = person.FirstName;
                    txtLastName.Text = person.LastName;
                    txtEmail.Text = person.Email;
                    txtPhone.Text = person.Phone;
                    txtPassword.Text = person.Password;
                    txtBalance.Text = client.Balance.ToString();
                }
                else
                {
                    MessageBox.Show("the Cliant Not Found", "Not Exests");
                }

            }
            else
            {
                MessageBox.Show("the Cliant Not Found", "Not Exests");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to perform this transaction?", "Deposit transaction", MessageBoxButtons.YesNo)==DialogResult.Yes) {
                clsClient client = clsClient.Find(Convert.ToInt32(txtAccountBalance.Text));
                
                    client.Balance += Convert.ToDecimal(txtDeposit.Text);
                    client.Save();
                txtBalance.Text = client.Balance.ToString();
            }
        }
    }
}
