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
    public partial class frmShowClientList : Form
    {
        public frmShowClientList()
        {
            InitializeComponent();
        }
        private void _RefreshContactsList()
        {

            dgvGetAllCliantData.DataSource = clsClient.GetAllCliantandAllInfo();
        }
        private void frmShowClientList_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

      
    }
}
