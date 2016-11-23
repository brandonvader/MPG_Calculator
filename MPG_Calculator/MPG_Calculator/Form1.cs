/*  The purpose of this program is to calculate Miles Per Gallon and Dollars Per Mile based on user input.
 *  
 *  This program is designed by Brandon Vader
 *  11-22-2016
 *  
 *  github.com/drakanis/MPG_Calculator 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPG_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMPG_Click(object sender, EventArgs e)
        {
            //Click MPG button to calculate MPG

            double dMiles, dGallons, dMPG;

            dMiles = Convert.ToDouble(txtMiles.Text);
            dGallons = Convert.ToDouble(txtGallons.Text);
            

            dMPG = dMiles / dGallons;

            lblMPG.Text = dMPG.ToString("###.##"); //Limiting to hundredths as further accuracy is not required
        }

        private void btnDPM_Click(object sender, EventArgs e)
        {
            //Click $/Mile button to calculate the Dollars per Mile cost (uasually cents per mile, but makes people feel better to see a 0 dollar)

            double dMiles, dGallons, dDPG, dDPM;

            dMiles = Convert.ToDouble(txtMiles.Text);
            dGallons = Convert.ToDouble(txtGallons.Text);
            dDPG = Convert.ToDouble(txtDPG.Text);

            dDPM = (dGallons * dDPG) / dMiles;

            lblDPM.Text = dDPM.ToString("c"); //Displays as currency (ie. dollar sign, and cents value)
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Click Clear to clear all output and input so that you can use program again

            txtDPG.Text = "";
            txtGallons.Text = "";
            txtMiles.Text = "";

            lblDPM.Text = "";
            lblMPG.Text = "";
        }
    }
}
