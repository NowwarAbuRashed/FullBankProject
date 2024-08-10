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
using System.Xml.Schema;

namespace FullBankProject
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private int AddPermissions(CheckedListBox Permissions)
        {
            int Total = 0;
            foreach (var permission in Permissions.CheckedItems)
            {
                switch (permission.ToString())
                {
                    case "Client List":
                        Total += 1;
                        break;
                    case "Delete Client":
                        Total += 2;
                        break;
                    case "Add New Client":
                        Total += 4;
                        break;
                    case "Update Client":
                        Total += 8;
                        break;
                    case "Find Client":
                        Total += 16;
                        break;
                    case "Transactions":
                        Total += 32;
                        break;
                    case "Manage Users":
                        Total += 64;
                        break;
                    case "Currency Exchange":
                        Total += 128;
                        break;

                }

            }
            return Total;
        }
            private void btnAdd_Click(object sender, EventArgs e)
            {
                clsPerson person = new clsPerson();
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Email = txtEmail.Text;
                person.Phone = txtPhone.Text;
                person.Password = txtPassword.Text;

                if (person.Save())
                {

                }
                else
                {
                    MessageBox.Show("The Save is Faild", "Erorr");
                    return;
                }
                clsUser User = new clsUser();
                User.UserName = txtUserName.Text;
                User.PersonID = person.ID;
                User.Permissions = AddPermissions(chlbPermissions);


                if (User.Save())
                {
                    MessageBox.Show("The Save is Successfuly", "Add");
                }
                else
                {
                    MessageBox.Show("The Save is Faild", "Erorr");
                }
            }
        }
    } 

