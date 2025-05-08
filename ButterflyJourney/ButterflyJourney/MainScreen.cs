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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void buttonButterflies_Click(object sender, EventArgs e)
        {
            PlantButterflyScreen butterflyForm = new PlantButterflyScreen(); // Create instance of the form
            butterflyForm.Show();  // Show the new form
            this.Hide();           // Optionally hide the current form
        }
       
        private void ButtonButterflyLifecycle_Click(object sender, EventArgs e)
        {
            ButterflyLifecycleScreen butterflyLifecycleScreen = new ButterflyLifecycleScreen();
            butterflyLifecycleScreen.Show();
            this.Hide(); // Optional: hides the current form
        }
        


        private void buttonGardenPlanning_Click(object sender, EventArgs e)
        {
            GardenPlanningScreen gardenPlanningScreen = new GardenPlanningScreen(); // Create form instance
            gardenPlanningScreen.Show();   // Show the new form
            this.Hide();                   // Optionally hide current form
        }

    }
}
    
    

