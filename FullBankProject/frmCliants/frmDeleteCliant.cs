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
    public partial class frmDeleteCliant : Form
    {
        public frmDeleteCliant()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you shor to Delete Cliant", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { clsClient.DeleteClient(Convert.ToInt32(txtAccountBalance.Text));
                MessageBox.Show("Deleted Successfuly","Deleted");
            }
        }
    }
}
