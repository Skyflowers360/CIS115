namespace Twitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string userMessage = txtMessage.Text;

            if (userMessage.Length > 140)
            {
                MessageBox.Show("Error: Message exceeds 140 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your message: " + userMessage, "Message Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
