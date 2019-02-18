using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class frmLunchOrder : Form
    {
        const double Tax = 7.75d;
        const double Hamburger = 6.95d;
        const double Pizza = 5.95d;
        const double Salad = 4.95d;

        double AddOn = 0.0d;  //adds on to the final sum

        double AddOnPrice = 0.0d; //additional addons
        double Order_Total = 0.0d;  //total order

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //adds on main courses
            if (radioHamburger.Checked)
                Order_Total += Hamburger;
            if (radioPizza.Checked)
                Order_Total += Pizza;
            if (radioSalad.Checked)
                Order_Total += Salad;

            Order_Total += AddOn;

            txtSubtotal.Text = "$" + String.Format("{0:0.00}", Order_Total);

            //tax
            double tax = (Order_Total * 7.75d) / 100;
            txtTax.Text = "$" + String.Format("{0:0.00}", tax);
            txtOrderTotal.Text = "$" + String.Format("{0:0.00}", (Order_Total + tax));
        }

        //hamburger sets the default radio buttons for addons, but changes when other main course is selected
        private void CheckLettuceTomatoOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckLettuceTomatoOnion.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;

            ClearOrderTotals();
        }
        private void CheckKatchupMusterdMayo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckKatchupMusterdMayo.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;
        }
        private void CheckFrenchFires_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckFrenchFires.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;
        }

        //when main course is hamburger
        private void radioHamburger_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderTotals();
            ClearAddOnItems();
            if (radioHamburger.Checked)
            {
                groupAddOnItems.Text = "Add-on items ($.75/each)";
                CheckLettuceTomatoOnion.Text = "Lettuce, tomato and onions";
                CheckKatchupMusterdMayo.Text = "Ketchup, mustard and mayo";
                CheckFrenchFires.Text = "French Fries";
                AddOnPrice = 0.75d;
            }
        }

        //when main course is pizza
        private void radioPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderTotals();
            ClearAddOnItems();

            if (radioPizza.Checked)
            {
                groupAddOnItems.Text = "Add-on items ($.50/each)";

                CheckLettuceTomatoOnion.Text = "Pepperoni";
                CheckKatchupMusterdMayo.Text = "Sausage";
                CheckFrenchFires.Text = "Olives";
                AddOnPrice = 0.50d;
            }
        }

        //when main course is salad
        private void radioSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderTotals();
            ClearAddOnItems();

            if (radioSalad.Checked)
            {
                groupAddOnItems.Text = "Add-on items ($.25/each)";
                CheckLettuceTomatoOnion.Text = "Croutons";
                CheckKatchupMusterdMayo.Text = "Bacon bits";
                CheckFrenchFires.Text = "Bread sticks ";
                AddOnPrice = 0.25d;
            }
        }

        private void ClearOrderTotals()
        {
            txtOrderTotal.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtTax.Text = string.Empty;
            Order_Total = 0.0d;
        }

        private void ClearAddOnItems()
        {
            AddOn = 0.0d;
            CheckLettuceTomatoOnion.Checked = false;
            CheckKatchupMusterdMayo.Checked = false;
            CheckFrenchFires.Checked = false;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
