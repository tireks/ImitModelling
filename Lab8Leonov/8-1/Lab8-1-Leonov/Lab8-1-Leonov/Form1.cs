using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_1_Leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double temp = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            Random rnd = new Random();
            temp = rnd.NextDouble();
            if (temp < 0.5)
            {
                textBox.Text = "Да!";
            }
            else if (temp > 0.5)
            {
                textBox.Text = "Никогда!";
            }
            else
            {
                textBox.Text = "Не знаю!";
            }
        }
    }
}
