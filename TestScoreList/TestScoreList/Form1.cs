using System;
using System.Windows.Forms;

namespace TestScoreList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int[] testScores = new int[8];
            int total = 0;
            bool validInput = true;

            for (int i = 0; i < 8; i++)
            {
                TextBox currentTextBox = (TextBox)this.Controls["textScore" + (i + 1)];

                // Check if the TextBox is empty
                if (string.IsNullOrWhiteSpace(currentTextBox.Text))
                {
                    MessageBox.Show($"Test Score {i + 1} cannot be empty.");
                    validInput = false;
                    break;
                }

                // Try to parse the input as an integer
                if (!int.TryParse(currentTextBox.Text, out testScores[i]))
                {
                    MessageBox.Show($"Please enter a valid integer for Test Score {i + 1}.");
                    validInput = false;
                    break;
                }

                total += testScores[i];
            }

            if (validInput)
            {
                double average = total / 8.0;

                listResults.Items.Clear(); // Clear the ListBox before displaying results

                for (int i = 0; i < 8; i++)
                {
                    double difference = testScores[i] - average;
                    listResults.Items.Add($"Test Score {i + 1}: {testScores[i]} (Difference from Average: {difference:F2})");
                }
            }
        }
    }
}
