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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you shor to Delete User", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(Convert.ToInt32(txtUserID.Text)))
                {
                    MessageBox.Show("Deleted Successfuly", "Deleted");
                }
                else
                {
                    MessageBox.Show("Deleted Faild", "Faild");
                }
            }
        }
    }
}
