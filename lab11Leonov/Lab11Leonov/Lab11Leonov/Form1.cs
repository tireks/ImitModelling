using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lab11Leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double theoMean = 0, theoVar = 0, statMean = 0, statVar = 0, Chi = 0;
        int size;
        double[] ChiValue = new double[12] { 3.841, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067, 15.507, 16.919, 18.307, 19.675, 21.026 };
        int stolb;
        double columnLength, h1, h2, max = -100000, min = 100000, curLength, pi = 0, px = 0, x = 0;
        int[] columnCount;
        double[] spanLen;
        double[] columnFreq;
        double[] normalDisp;
        Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            theoMean = (double)meanEd.Value;
            theoVar = (double)varianceEd.Value;
            size = (int)numOfTrials.Value;

            normalDisp = new double[size];
            for (int i = 0; i < size; i += 2)
            {
                h1 = rand.NextDouble();
                h2 = rand.NextDouble();
                normalDisp[i] = Math.Sqrt((-2) * Math.Log(h1)) * Math.Sin(2 * Math.PI * h2) * Math.Sqrt(theoVar) + theoMean;
                normalDisp[i + 1] = Math.Sqrt((-2) * Math.Log(h1)) * Math.Cos(2 * Math.PI * h2) * Math.Sqrt(theoVar) + theoMean;

                if (normalDisp[i] > max) max = normalDisp[i];
                if (normalDisp[i + 1] > max) max = normalDisp[i + 1];
                if (normalDisp[i] < min) min = normalDisp[i];
                if (normalDisp[i + 1] < min) min = normalDisp[i + 1];

                statMean += normalDisp[i] + normalDisp[i + 1];
                statVar += normalDisp[i] * normalDisp[i] + normalDisp[i + 1] * normalDisp[i + 1];
            }
            statMean = statMean / size;
            statVar = statVar / size - statMean * statMean;

            stolb = (int)Math.Log(size, 2) + 1;
            columnLength = (max - min) / stolb;
            columnCount = new int[stolb];

            for (int i = 0; i < size; i++)
            {
                curLength = min + columnLength;
                int j = 0;
                while (j < stolb)
                {
                    if (normalDisp[i] < curLength)
                    {
                        columnCount[j]++;
                        break;
                    }
                    else
                    {
                        curLength += columnLength;
                        j++;
                    }
                }
                normalDisp[i] = 0;
            }

            spanLen = new double[stolb + 1];
            columnFreq = new double[stolb];
            double min1 = min;

            for (int i = 0; i < stolb; i++)
            {
                columnFreq[i] = (double)columnCount[i] / size;
                x = (min1 + min1 + columnLength) / 2;
                px = (1 / (Math.Sqrt(2 * Math.PI) * Math.Sqrt(theoVar))) * Math.Exp(-((x - theoMean) * (x - theoMean)) / (2 * theoVar));
                pi = ((min1 + columnLength) - min1) * px;
                Chi += (columnCount[i] * columnCount[i]) / (double)(size * pi);
                spanLen[i] = min1;

                chart1.Series[0].Points.AddXY(min1, columnFreq[i]);
                min1 += columnLength;

            }
            chart1.Series[0].Points.AddXY(min1, columnFreq[stolb - 1]);
            Chi -= size;

            meanTextBox.Text = Math.Round(statMean, 2).ToString();
            varianceTextBox.Text = Math.Round(statVar, 2).ToString();
            if (Chi > ChiValue[stolb - 2])
            {
                chiTextBox.Text = "true";
            }
            else
            {
                chiTextBox.Text = "false";
            }
        }
    }
}
