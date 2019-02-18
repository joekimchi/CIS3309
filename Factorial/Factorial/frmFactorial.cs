using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //exits program
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //defines the variable
            int num = Convert.ToInt32(txtNumber.Text);
            long factorial = 1;

            //factorial
            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }

            String str = factorial.ToString("N0"); //N0 adds commas after every three digits 

            txtFactorial.Text = str.Substring(0);

        }
    }
}
