using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class ScoreCalculator : Form
    {
        public ScoreCalculator()
        {
            InitializeComponent();
        }

        //initializers
        int ScoreTotal = 0;
        int ScoreCount = 0;
        int[] arr = new int[20];
        int i = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    int score = Convert.ToInt32(txtScore.Text);
                    arr[i] = score; //sets scores into array

                    ScoreTotal += arr[i]; //adds score to previous score
                    ScoreCount++; //increments score count
                    
                    txtScoreTotal.Text = ScoreTotal.ToString();
                    txtScoreCount.Text = ScoreCount.ToString();
                    txtAverage.Text = Convert.ToString((int)(ScoreTotal / ScoreCount)); //average 

                    i++; //increments array
                    txtScore.Focus();
                }
            }
            catch (Exception ex) //in case user inputs anything but numbers
            {
                MessageBox.Show("Please enter valid input");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //zeros out everything
            ScoreTotal = 0;
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Focus();
        }

        public bool IsValidData()
        {
            return
                IsPresent(txtScore, "Score") &&
                IsInt32(txtScore, "Score") &&
                IsWithinRange(txtScore, "Score", 01, 100);
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                return false;
            }
            else return true;
        }

        public bool IsInt32(TextBox textBox, string name)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                return true;
            }
            else
                return false;
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            if (Convert.ToInt32(textBox.Text) > max || Convert.ToInt32(textBox.Text) < min)
            {
                return false;
            }
            else
                return true;
        }


        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            Array.Resize(ref arr, i);
            string DisplayScores = string.Join(Environment.NewLine, arr);
            MessageBox.Show(DisplayScores);
        }
    }
}