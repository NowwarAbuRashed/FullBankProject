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
    public partial class frmFindUser : Form
    {
        public frmFindUser()
        {
            InitializeComponent();
        }
        private void FindChickBoks(int UserPermission, ref CheckedListBox Permissions)
        {

            int Total = UserPermission;
            if ((Total & 1) > 0)
            {
                Permissions.SetItemChecked(0, true);
            }
            else
            {
                Permissions.SetItemChecked(0, false);
            }
            if ((Total & 2) > 0)
            {
                Permissions.SetItemChecked(1, true);
            }
            else
            {
                Permissions.SetItemChecked(1, false);
            }
            if ((Total & 4) > 0)
            {
                Permissions.SetItemChecked(2, true);
            }
            else
            {
                Permissions.SetItemChecked(2, false);
            }
            if ((Total & 8) > 0)
            {
                Permissions.SetItemChecked(3, true);
            }
            else
            {
                Permissions.SetItemChecked(3, false);
            }
            if ((Total & 16) > 0)
            {
                Permissions.SetItemChecked(4, true);
            }
            else
            {
                Permissions.SetItemChecked(4, false);
            }
            if ((Total & 32) > 0)
            {
                Permissions.SetItemChecked(5, true);
            }
            else
            {
                Permissions.SetItemChecked(5, false);
            }
            if ((Total & 64) > 0)
            {
                Permissions.SetItemChecked(6, true);
            }
            else
            {
                Permissions.SetItemChecked(6, false);
            }
            if ((Total & 128) > 0)
            {
                Permissions.SetItemChecked(7, true);
            }
            else
            {
                Permissions.SetItemChecked(7, false);
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(Convert.ToInt32(txtUserID.Text));
            if (User != null)
            {
                clsPerson person = clsPerson.Find(User.PersonID);
                if (person != null)
                {
                    txtFirstName.Text = person.FirstName;
                    txtLastName.Text = person.LastName;
                    txtEmail.Text = person.Email;
                    txtPhone.Text = person.Phone;
                    txtPassword.Text = person.Password;
                    txtUserName.Text = User.UserName;
                    FindChickBoks(User.Permissions, ref chlbPermissions);
                }
            }
        }
    }
}
