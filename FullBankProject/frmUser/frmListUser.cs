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
    public partial class frmListUser : Form
    {

        private void _RefreshTransferList()
        {

            dgvListUser.DataSource = clsUser.GetAllUsersAllInfo();
        }
        public frmListUser()
        {
            InitializeComponent();
            _RefreshTransferList();
        }
    }
}
