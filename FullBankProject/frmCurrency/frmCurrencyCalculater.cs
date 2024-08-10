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
    public partial class frmCurrencyCalculater : Form
    {
        public frmCurrencyCalculater()
        {
            InitializeComponent();
        }
        public static  double ConvertCurrency(double amount, clsCurrencie currencieFrom, clsCurrencie currencieTo)
        {
            double fromRate =  currencieFrom.Rat1Dolar;
            double toRate = currencieTo.Rat1Dolar;

            if (fromRate == 0 || toRate == 0)
            {
                throw new Exception("Invalid currency code or rate not found.");
            }

            double amountInBaseCurrency = amount / fromRate;
            double convertedAmount = amountInBaseCurrency * toRate;

            return convertedAmount;
        }
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            clsCurrencie currencieFrom= clsCurrencie.Find(txtConvertFrom.Text);
            if (currencieFrom != null)
            {
                clsCurrencie currencieTo = clsCurrencie.Find(txtConvertTo.Text);
                if (currencieTo != null)
                {
                    if (txtAmount.Text.Length > 0)
                    {
                        double Result = ConvertCurrency(Convert.ToDouble(txtAmount.Text), currencieFrom, currencieTo);
                        txtResult.Text = Result.ToString();
                    }
                }
            }

        }
    }
}
