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
    public partial class frmFindCliant : Form
    {
        public frmFindCliant()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(Convert.ToInt32(txtAccountBalance.Text));
            clsPerson person = clsPerson.Find(client.PersonID);

            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtEmail.Text = person.Email;
            txtPhone.Text = person.Phone;
            txtPassword.Text = person.Password;
            txtBalance.Text=client.Balance.ToString();
        }
    }
}
