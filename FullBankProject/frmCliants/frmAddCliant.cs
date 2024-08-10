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
    public partial class frmAddCliant : Form
    {
        public frmAddCliant()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsPerson person=new clsPerson();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.Email = txtEmail.Text;
            person.Phone = txtPhone.Text;
            person.Password = txtPassword.Text;

            if(person.Save())
            {

            }
            else
            {
                MessageBox.Show("The Save is Faild", "Erorr");
                return;
            }
            clsClient Client = new clsClient();
            Client.PersonID = person.ID;
            Client.Balance = Convert.ToDecimal(txtBalance.Text);

            if(Client.Save())
            {
                MessageBox.Show("The Save is Successfuly", "Add");
            }
            else
            {
                MessageBox.Show("The Save is Faild", "Erorr");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
