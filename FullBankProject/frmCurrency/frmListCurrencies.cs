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
    public partial class frmListCurrencies : Form
    {
        private void _RefreshCurrenciesList()
        {

            dgvListCurrencies.DataSource = clsCurrencie.GetAllCurrencieAndAllInfo();
        }
        public frmListCurrencies()
        {
            InitializeComponent();
            _RefreshCurrenciesList();
        }
    }
}
