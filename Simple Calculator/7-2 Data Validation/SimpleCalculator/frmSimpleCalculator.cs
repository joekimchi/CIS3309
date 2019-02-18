using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
            {
                result = operand1 + operand2;
            }
            else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }
            else if (operator1 == "*")
            {
                result = operand1 * operand2;
            }
            else if (operator1 == "/")
            {
                result = operand1 / operand2;
            }
            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                    decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                    string operator1 = txtOperator.Text;
                    decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                    decimal result = Calculate(operand1, operator1, operand2); //first number, operator, second number inputs

                    result = Math.Round(result, 4);
                    this.txtResult.Text = result.ToString();
                    txtOperand1.Focus();
                }
            //catches any exception
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        public bool IsPresent(TextBox input, string name)
        {
            //if empty
            if (input.Text == "")
            {
                //Printing exception details
                MessageBox.Show("Please enter a value for " + name, "Entry Error");
                input.Focus();
            }
            return false;
        }

        public bool IsDecimal(TextBox input, string name)
        {
            decimal number = 0m;

            if (Decimal.TryParse(input.Text, out number))
            {
                return true;
            }

            else
            {
                MessageBox.Show("Please enter a decimal for " + name, "Entry Error");
                input.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox input, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(input.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                input.Focus();
                return false;
            }
            return true;
        }

        //Checks that the text box that’s passed to it contains a value of +, -, *, or /
        public bool IsOperator(TextBox input, string name)
        {
            {
                if (input.Text != "+" && input.Text != "-" && input.Text != "/" && input.Text != "*")
                {
                    MessageBox.Show("Enter +, -, *, or / in the operator box", "Entry Error");
                    return false;
                }
                return true;
            }
        }

        //Checks that the Operand 1 and Operand 2 text boxes contain a decimal value 
        //between 0 and 1,000,000 (non-inclusive) and that the Operator text box 
        //contains a valid operator
        public bool IsValidData()
        {
            return
            //validates operand1
            IsPresent(txtOperand1, "Operand 1") &&
            IsDecimal(txtOperand1, "Operand 1") &&
            IsWithinRange(txtOperand1, "Operand 1", 0, 1000000) 
            
            &&

            //validates operand2
            IsPresent(txtOperand2, "Operand 2") &&
            IsDecimal(txtOperand2, "Operand 2") &&
            IsWithinRange(txtOperand2, "Operand 2", 0, 1000000) 
            
            &&

            //validates operator text box
            IsOperator(txtOperand1, "Operator 1");
        }
    }
}