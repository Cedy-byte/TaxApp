using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxCalculator;

namespace TaxApp
{
    public partial class TaxApp : Form
    {
        public TaxApp()
        {
            InitializeComponent();
        }

        // This method calculates VAT based on the price of a product
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            double price = Convert.ToDouble(txbPrice.Text);

            Tax tax = new Tax();
            MessageBox.Show("Name: "+ name + "\n"
                + "Price : R "+ price+ "\n"
                 + "VAT : R " + tax.CalculateVat(price).ToString());
        }

        // This method calculates the UIF based on the income amount
        private void btnUIF_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            double income = Convert.ToDouble(txbIncome.Text);
            
            Tax tax = new Tax();
            MessageBox.Show("Name: " + name + "\n"
                + "Income : R "+ income + "\n"
                +"UIF : R "+ tax.calculateUIF(income).ToString());
        }
    }
}
