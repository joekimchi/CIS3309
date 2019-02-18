using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
	public partial class frmAreaAndPerimeter : Form
	{
		public frmAreaAndPerimeter()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
            double length, width, area, perimeter;

            //takes inputs
            length = Convert.ToDouble(txtLength.Text);
            width = Convert.ToDouble(txtWidth.Text);

            area = length * width; //area formula
            perimeter = (2 * width) + (2 * length); //perimeter formula

            //outputs results from numbers given in length/width for area/perimeter
            txtArea.Text = Convert.ToString(area);
            txtPerimeter.Text = Convert.ToString(perimeter);
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
