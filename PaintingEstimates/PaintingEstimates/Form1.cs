using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingEstimates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textLength.Text, out double length) && double.TryParse(textWidth.Text, out double width))
            {
                double totalCost = CalculatePaintingCost(length, width);
                labelResult.Text = $"Total painting cost: ${totalCost:F2}";
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for length and width.");
            }
        }

        private double CalculatePaintingCost(double length, double width)
        {
            double wallHeight = 9.0;
            double perimeter = 2 * (length + width);
            double wallArea = perimeter * wallHeight;
            double costPerSquareFoot = 6.0;
            return wallArea * costPerSquareFoot;
        }
    }
}