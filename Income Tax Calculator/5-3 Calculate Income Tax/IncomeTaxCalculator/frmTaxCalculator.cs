using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeTaxCalculator
{
    public partial class frmTaxCalculator : Form
    {
        public frmTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal input = Convert.ToDecimal(txtTaxableIncome.Text);

            decimal owedTax = 0m;

            //m represents a decimal (for percentage)

            //over $0 but not over $9,225
            if (input <= 9225)
            {
                owedTax = (int)(input * .10m);
            }

            //over $9,225 but not over $37,450
            else if (input > 9225 && input <= 37450)
            {
                owedTax = 922.50m + (int)((input - 9225) * .15m);
            }

            //over $37,450 but not over $90,750
            else if (input > 37450 && input <= 90750)
            {
                owedTax = 5156.25m + (int)((input - 37450) * .25m);
            }
            
            //over $90,750 but not over $189,300
            else if (input > 90750 && input <= 189300)
            {
                owedTax = 18481.25m + (int)((input - 90750) * .28m);
            }

            //over $189,300 but not over $411,500
            else if (input > 189300 && input <= 411500)
            {
                owedTax = 46075.25m + (int)((input - 189300) * .33m);
            }

            //over $411,500 but not over $413,200
            else if (input > 411500 && input <= 413200)
            {
                owedTax = 119401.25m + (int)((input - 411500) * .35m);
            }

            //$413,200 and above
            else
            {
                owedTax = 119996.25m + (int)((input - 413200) * .396m);
            }

            txtIncomeTaxOwed.Text = owedTax.ToString(); //Income Tax Owed
        }
    }
}
