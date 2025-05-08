using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButterflyJourney
{
    public partial class PlantButterflyScreen : Form
    {
        public PlantButterflyScreen()
        {
            InitializeComponent();
        }

        // ✅ Correct event handler for Back to Home button
        private void ButtonBackToHome_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen(); // Create a new instance of MainScreen
            mainScreen.Show();                        // Show the MainScreen form
            this.Close();                             // Close the current form
        }

        private void PlantButterflyScreen_Load(object sender, EventArgs e)
        {
            // Optional: any initialization code when the form loads
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen(); // Open MainScreen
            mainScreen.Show();                        // Show the main screen
            this.Close();                             // Close the current form
        }

    }
}
