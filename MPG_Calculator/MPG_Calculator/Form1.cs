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
            double dMiles, dGallons, dMPG;

            dMiles = Convert.ToDouble(txtMiles.Text);
            dGallons = Convert.ToDouble(txtGallons.Text);
            

            dMPG = dMiles / dGallons;

            lblMPG.Text = dMPG.ToString("##.##");
        }

        private void btnDPM_Click(object sender, EventArgs e)
        {
            double dMiles, dGallons, dDPG, dDPM;

            dMiles = Convert.ToDouble(txtMiles.Text);
            dGallons = Convert.ToDouble(txtGallons.Text);
            dDPG = Convert.ToDouble(txtDPG.Text);

            dDPM = (dGallons * dDPG) / dMiles;

            lblDPM.Text = dDPM.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDPG.Text = "";
            txtGallons.Text = "";
            txtMiles.Text = "";

            lblDPM.Text = "";
            lblMPG.Text = "";
        }
    }
}
