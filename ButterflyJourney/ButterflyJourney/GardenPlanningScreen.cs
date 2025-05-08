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
    public partial class GardenPlanningScreen : Form
    {
        public GardenPlanningScreen()
        {
            InitializeComponent();
        }

        // ✅ This method is called when the Back to Home button is clicked
        private void buttonBacktoHome_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen(); // Create a new instance of MainScreen
            main.Show();                        // Show MainScreen
            this.Close();                       // Close the current screen
        }
    }
}

