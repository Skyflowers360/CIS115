using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCharges
{
    public partial class Form1 : Form
    {
        int[] zipCodes = { 27510, 27502, 27511, 28358, 28625, 28779, 28801, 27401, 28205, 27601 };
        decimal[] deliveryCharges = { 15.00m, 20.00m, 25.00m, 18.50m, 22.00m, 19.75m, 21.00m, 23.50m, 17.00m, 24.00m };

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheckDelivery_Click(object sender, EventArgs e)
        {
            string userInput = textZipCode.Text;
            bool found = false;

            if (int.TryParse(userInput, out int enteredZip))
            {
                for (int i = 0; i < zipCodes.Length; i++)
                {
                    if (zipCodes[i] == enteredZip)
                    {
                        labelResult.Text = $"The delivery charge to zip code {enteredZip} is ${deliveryCharges[i]:0.00}.";
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    labelResult.Text = $"Sorry, we do not deliver to zip code {enteredZip}.";
                }
            }
            else
            {
                labelResult.Text = "Please enter a valid zip code.";
            }
        }
    }
}