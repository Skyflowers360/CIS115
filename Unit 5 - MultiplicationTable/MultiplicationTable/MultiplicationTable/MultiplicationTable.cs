namespace MultiplicationTable
{
    public partial class MultiplicationTable : Form
    {
        public MultiplicationTable()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int number;
            bool isValid = int.TryParse(textBox1.Text, out number);


            if (isValid)
            {

                for (int i = 1; i <= 10; i++)
                {
                    int result = i * number;
                    listBoxresults.Items.Add($"{i} * {number} = {result}");
                }
            }
            else
            {
                // If not valid, show an error message
                MessageBox.Show("Please enter a valid integer number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}