using System;
using System.Windows.Forms;

namespace DailyTemps
{
    public partial class DailyTemps : Form
    {
        private int[] temperatures = new int[7];
        private int totalTemperature = 0;

        public DailyTemps()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            TextBox[] tempTextBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            bool allValid = true;
            totalTemperature = 0;

            for (int i = 0; i < tempTextBoxes.Length; i++)
            {
                int enteredTemperature;
                if (int.TryParse(tempTextBoxes[i].Text, out enteredTemperature) && enteredTemperature >= -20 && enteredTemperature <= 130)
                {
                    temperatures[i] = enteredTemperature;
                    totalTemperature += enteredTemperature;
                }
                else
                {
                    allValid = false;
                    break;
                }
            }

            if (allValid)
            {
                double averageTemperature = totalTemperature / 7.0;
                labelresult.Text = "Temperatures: " + string.Join(", ", temperatures) +
                                 "\nAverage Temperature: " + averageTemperature.ToString("F2");

                buttonsubmit.Enabled = true;

                foreach (var textBox in tempTextBoxes)
                {
                    textBox.Clear();
                }
            }
            else
            {
                labelresult.Text = "Please enter valid temperatures between -20 and 130°F.";
            }
        }
    }
}
