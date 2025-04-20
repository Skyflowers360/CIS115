using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineForOverdueBooks
{
    public partial class FineForOverdueBooks : Form
    {
        public FineForOverdueBooks()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBooks.Text, out int books) && int.TryParse(textDays.Text, out int days))
            {
                double fine = CalculateFine(books, days);
                lableResults.Text = $"Total fine: ${fine:F2}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for books and days.");
            }
        }

        private double CalculateFine(int books, int days)
        {
            const double rateFirst7Days = 0.10;
            const double rateAfter7Days = 0.20;

            int daysAtRate1 = Math.Min(days, 7);
            int daysAtRate2 = Math.Max(days - 7, 0);

            double fine = (books * daysAtRate1 * rateFirst7Days) + (books * daysAtRate2 * rateAfter7Days);
            return fine;
        }
    }
}
