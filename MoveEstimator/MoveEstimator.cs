using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTwoNumbers
{
    public partial class MoveEstimator : Form
    {
        public MoveEstimator()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            double hours = double.Parse(textBoxHours.Text);
            double miles = double.Parse(textBoxMiles.Text);
            double baseRate = 200;
            double hourlyRate = 150;
            double mileRate = 2;
            double result = baseRate + (hourlyRate * hours) + (mileRate * miles);
            results.Text = "Total Moving Fee: $" + result.ToString("f2");

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
