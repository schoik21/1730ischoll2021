using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ischoll1f1
{
    public partial class w : Form
    {
        public w()
        {
            InitializeComponent();
        }

        private void w_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.717976";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = "Australian Dollar:"; 
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            lblCurrency.Text = "Bhutanese Ngultrum:";
            txtRate.Text = "0.0139831";
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            lblCurrency.Text = "Costa Rican Colon:";
            txtRate.Text = "0.00176122";
        }

        private void btnEurope_Click(object sender, EventArgs e)
        {
            btnEurope.BackgroundImage = picEurope.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            lblCurrency.Text = "Euro:";
            txtRate.Text = "1.15528";
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (Convert.ToDecimal(txtCurrency.Text) *
                Convert.ToDecimal(txtRate.Text)).ToString("0.00" );
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtRate_Enter(object sender, EventArgs e)
        {
            txtRate.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDollars.Text) +
                Convert.ToDecimal(txtTotalUSD.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + "+" + txtUSDollars.Text;
            txtCurrency.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.717976";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }
    }
}
      

