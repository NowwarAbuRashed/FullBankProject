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
    public partial class frmTransferLog : Form
    {
        public frmTransferLog()
        {
            InitializeComponent();
        }

        private void _RefreshTransferList()
        {

            dgvGetTransferLog.DataSource = clsTransfers.GetAllTransferLog();
        }

        private void frmTransferLog_Load(object sender, EventArgs e)
        {
            _RefreshTransferList();
        }
    }
}
