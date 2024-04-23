using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_3_Leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] prob1, prob2;
        int N; 
        int[] stat;
        double temp;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            prob1 = new double[5];
            prob2 = new double[5];
            stat = new int[5];
            N = (int)numericUpDown6.Value;
            prob1[0] = (double)numericUpDown1.Value;
            prob1[1] = (double)numericUpDown2.Value;
            prob1[2] = (double)numericUpDown3.Value;
            prob1[3] = (double)numericUpDown4.Value;
            prob1[4] = 1;
            for (int i = 0; i < 4; i++)
            {
                prob1[4] -= prob1[i];
                textBox1.Text = prob1[4].ToString();
            }
            for (int i = 0; i < N; i++)
            {
                temp = rnd.NextDouble();
                double sum = 0;
                for (int k = 0; k < 5; k++)
                {
                    sum += prob1[k];
                    if (temp <= sum)
                    {
                        stat[k]++;
                        break;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                prob2[i] = stat[i] / (double)N;
            }
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, prob2[i]);
            }
        }
    }
}
