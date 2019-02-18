using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class frmChangeCalculator : Form
    {
        public frmChangeCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int quarter = 25;
            const int dime = 10;
            const int nickel = 5;
            const int penny = 1;
            int input = Convert.ToInt32(txtAmountOfChangeDue.Text);

            if (input >= quarter)
            {
                txtQuarters.Text = (input / quarter).ToString();
                input = input % quarter; //modulus quarter
            }

            if (input >= dime)
            {
                txtDimes.Text = (input / dime).ToString();
                input = input % dime; //modulus dime
            }

            if (input >= nickel)
            {
                txtNickels.Text = (input / nickel).ToString();
                input = input % nickel; //modulus nickel
            }

            if (input >= penny)
            {
                txtPennies.Text = (input / penny).ToString();
                input = input % penny; //modulus penny
            }
        }
    }
}
