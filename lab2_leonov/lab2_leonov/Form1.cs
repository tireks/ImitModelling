using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.01;
        double rateEuro, rateDollar;
        int t;

        Random rand = new Random();

        private void btnPredict_Click(object sender, EventArgs e)
        {

            rateEuro = (double)editRate.Value;
            rateDollar = (double)editRateDollar.Value;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            chart1.Series[0].Points.AddXY(0, rateEuro);
            chart1.Series[1].Points.AddXY(0, rateDollar);

            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 1;

            rateEuro = rateEuro * (1 + k * (rand.NextDouble() - 0.5));
            rateDollar = rateDollar * (1 + k * (rand.NextDouble() - 0.5));

            chart1.Series[0].Points.AddXY(t, rateEuro);
            chart1.Series[1].Points.AddXY(t, rateDollar);
        }
    }
}
