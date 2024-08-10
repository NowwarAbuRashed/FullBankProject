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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }
       private static  clsClient _clientFrom;
       private static clsClient _clientTo;
       private static clsPerson _personFrom;
       private static clsPerson _personTo;

        private void btnOK_Click(object sender, EventArgs e)
        {
             

            if (_clientFrom.Balance < Convert.ToDecimal(txtTransferAmount.Text))
            {
                MessageBox.Show("Amount Exceeds the available Balance");
                return;
            }
            if (MessageBox.Show("Are you sure you want to perform this operation","TransAction", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {

              int TransferLogID=  clsTransfers.AddTransferLog(DateTime.Now, Convert.ToDecimal(txtTransferAmount.Text));


                _clientFrom.Balance -= Convert.ToDecimal(txtTransferAmount.Text);
                _clientTo.Balance += Convert.ToDecimal(txtTransferAmount.Text);
                _clientFrom.Save();
                _clientTo.Save();
                txtBalanceFrom.Text= _clientFrom.Balance.ToString();
                txtBalanceTo.Text= _clientTo.Balance.ToString();

                clsTransfers.AddTransfersInfo(clsGlobal.UserLogIn.ID, _clientFrom.ID, _clientTo.ID, TransferLogID);



            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
             _clientFrom = clsClient.Find(Convert.ToInt32(txtTransferFrom.Text));
            if (_clientFrom == null)
            {
                MessageBox.Show("Enter Another Account Balance", "Not Found");
                return;
            }
            _clientTo = clsClient.Find(Convert.ToInt32(txtTransferTo.Text));
            if (_clientTo == null)
            {
                MessageBox.Show("Enter Another Account Balance", "Not Found");
                return;
            }
             _personFrom = clsPerson.Find(_clientFrom.PersonID);
             _personTo = clsPerson.Find(_clientTo.PersonID);


            txtFullNameFrom.Text = _personFrom.FirstName + " " + _personFrom.LastName;
            txtAccountBalanceFrom.Text = _clientFrom.ID.ToString();
            txtBalanceFrom.Text = _clientFrom.Balance.ToString();

            txtFullNameTo.Text = _personTo.FirstName + " " + _personTo.LastName;
            txtAccountBalanceTo.Text = _clientTo.ID.ToString();
            txtBalanceTo.Text = _clientTo.Balance.ToString();
        }
    }
}
