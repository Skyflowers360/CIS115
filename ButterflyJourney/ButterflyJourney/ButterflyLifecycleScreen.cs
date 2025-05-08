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
    public partial class ButterflyLifecycleScreen : Form
    {
        public ButterflyLifecycleScreen()
        {
            InitializeComponent();
        }

        // ✅ This method runs when buttonBacktoHome is clicked
        private void buttonBacktoHome_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen(); // Create an instance of MainScreen
            main.Show();                        // Show MainScreen
            this.Close();                       // Close the current screen
        }
    }
}

