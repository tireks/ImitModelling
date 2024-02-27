using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double g = 9.81, C = 0.15, p = 1.29;

        double height, weight, angle, speed, size, step, sina, cosa, t, x, y, vx, vy, b, k;

        int counter = -1;

        private void btnStart_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 4)
            {
                for (int i = 0; i <= 4; i++)
                {
                    chart.Series[i].Points.Clear();
                }
                counter = 0;
            }
            height = (double)editHeight.Value;
            weight = (double)editWeight.Value;
            speed = (double)editSpeed.Value;
            size = (double)editSize.Value;
            angle = (double)editAngle.Value;
            step = (double)editStep.Value;

            cosa = Math.Cos(angle * Math.PI / 180);
            sina = Math.Sin(angle * Math.PI / 180);

            b = 0.5 * C * size * p;
            k = b / weight;

            t = 0; x = 0; y = height;
            vx = speed * cosa;
            vy = speed * sina;

            chart.Series[counter].Points.AddXY(x, y);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double vxPrevious = vx, vyPrevious = vy;
            double root = Math.Sqrt(vx * vx + vy * vy);

            t += step;
            vx = vxPrevious - k * vxPrevious * root * step;
            vy = vyPrevious - (g + k * vyPrevious * root) * step;
            x += vx * step;
            y += vy * step;
            chart.Series[counter].Points.AddXY(x, y);
            if (y <= 0) { timer.Stop(); }
        }
    }
}
