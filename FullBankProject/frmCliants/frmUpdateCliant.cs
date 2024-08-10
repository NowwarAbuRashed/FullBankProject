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
    public partial class frmUpdateCliant : Form
    {
        public frmUpdateCliant()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(Convert.ToInt32(txtAccountBalance.Text));
            clsPerson person = clsPerson.Find(client.PersonID);
     
                    person.FirstName =txtFirstName.Text;
                    person.LastName =txtLastName.Text;
                    person.Email =txtEmail.Text;
                    person.Phone =txtPhone.Text;
                    person.Password =txtPassword.Text;
                    person.Save();
                    client.Balance=Convert.ToDecimal(txtBalance.Text);
                    client.Save();

            MessageBox.Show("the Cliant Update Successfuly", "Update Successfuly");

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
                    txtBalance.Text=client.Balance.ToString();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
