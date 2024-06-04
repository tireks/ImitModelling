using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13Leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double m = 0, sd = 0.015, k = m - 0.5 * sd * sd;

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = Math.Ceiling(day);

            Random rand = new Random();
            temp = rand.NextDouble();
            temp2 = rand.NextDouble();
            boxG = Math.Sqrt(-2.0 * Math.Log(temp)) * Math.Cos(2.0 * Math.PI * temp2);

            euro = euro * Math.Exp(k + sd * boxG);
            dollar = dollar * Math.Exp(k + sd * boxG);

            chart1.Series[0].Points.AddXY(day, dollar);
            chart1.Series[1].Points.AddXY(day, euro);
            day++;
        }

        double euro, dollar, day, boxG, temp, temp2;

        private void btn_Click(object sender, EventArgs e)
        {
            day = 1;
            euro = (double)euroEdit.Value;
            dollar = (double)dollarEdit.Value;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, dollar);
            chart1.Series[1].Points.Clear();
            chart1.Series[1].Points.AddXY(0, euro);

            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false)
            {
                btn.Text = "Start";
            }
            else
            {
                btn.Text = "Stop";
            }
        }
    }
}
