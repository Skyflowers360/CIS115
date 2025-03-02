using System.Linq.Expressions;

namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClassify_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the wind speed input from the user
                double windSpeed = Convert.ToDouble(textWindSpeed.Text);

                string category = "";

                if (windSpeed >= 157)
                {
                    category = "Category 5: Hurricane";
                }
                else if (windSpeed >= 130)
                {
                    category = "Category 4: Hurricane";
                }
                else if (windSpeed >= 111)
                {
                    category = "Category 3: Hurricane";
                }
                else if (windSpeed >= 96)
                {
                    category = "Category 2: Hurricane";
                }
                else if (windSpeed >= 74)
                {
                    category = "Category 1: Hurricane";
                }
                else if (windSpeed < 74 && windSpeed >= 0)
                {
                    category = "Not a Hurricane";
                }
                else
                {
                    category = "Invalid wind speed.";
                }

                // Display the category in the label
                labelCategory.Text = category;
            }
            catch (FormatException)
            {
                // Handle invalid input (non-numeric value)
                MessageBox.Show("Please enter a valid numeric value for wind speed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
        