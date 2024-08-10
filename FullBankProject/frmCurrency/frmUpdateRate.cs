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
    public partial class frmUpdateRate : Form
    {
        public frmUpdateRate()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            clsCurrencie currencie = clsCurrencie.Find(txtCodeOrCountry.Text);
            if (currencie != null)
            {
                txtCode.Text = currencie.Code;
                txtCountry.Text = currencie.Country;
                txtCurrenciesName.Text = currencie.CurrenciesName;
                txtRat1Dolar.Text = currencie.Rat1Dolar.ToString();

            }
            else
            {
                MessageBox.Show("Enter Another Code Or Country", "Not Found");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsCurrencie currencie = clsCurrencie.Find(txtCodeOrCountry.Text);
            currencie.Rat1Dolar = Convert.ToDouble( txtRat1Dolar.Text);
            if(currencie.Save())
            {
                MessageBox.Show("the Update Successfuly", "Update Currencie");
            }
            else
            {
                MessageBox.Show("the Update Fiald", "Update Currencie");
            }

        }
    }
}
