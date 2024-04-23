using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2_Leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double temp = 0, sum = 0;
        double[] prob = { 0.1, 0.15, 0.09, 0.17, 0.15, 0.21, 0.05, 0.22 };
        string[] pred = { "Бесспорно!", "Думаю нет!", "Насколько я вижу да!",
            "Трудно сказать!", "Может быть!", "Точно нет!", "Да, это так!", "Извини, нет!"  };

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sum = 0;
            for (int i = 0; i < 8; i++)
            {
                textBox.Clear();
                sum += prob[i];
                temp = rnd.NextDouble();
                if (temp < sum)
                {
                    textBox.Text = pred[i];
                    break;
                }
            }
        }
    }
}
