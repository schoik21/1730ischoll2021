using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ischoll2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = 10m;
            decimal rateAustralia = 0.717976m;
            decimal USDAustralia = amountAustralia * rateAustralia;

            decimal amountBhutan = 100m;
            decimal rateBhutan = 0.0139831m;
            decimal USDBhutan = amountBhutan * rateBhutan;

            decimal amountCostaRica = 1000m;
            decimal rateCostaRica = 0.00176122m;
            decimal USDCostaRica = amountCostaRica * rateCostaRica;

            decimal amountEuro = 10m;
            decimal rateEuro = 1.15528m;
            decimal USDEuro = amountEuro * rateEuro; 

            decimal TotalUSD = USDAustralia + USDBhutan + USDCostaRica + USDEuro; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.717976";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0139831";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.00176122";
            txtAmountEuro.Text = "0,00";
            txtRateEuro.Text = "1.15528";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
