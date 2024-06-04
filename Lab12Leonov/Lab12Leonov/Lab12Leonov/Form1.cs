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

namespace Lab12Leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            InitFormAndModel();
        }

        private void Start()
        {
            InitFormAndModel();
            btn.Text = "Пауза";
            timer1.Enabled = true;
        }

        private void Pause()
        {
            btn.Text = "Продолжить";
            timer1.Enabled = false;
        }

        private void Continue()
        {
            btn.Text = "Пауза";
            timer1.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            switch (button.Text)
            {
                case "Старт":
                    Start();
                    break;
                case "Продолжить":
                    Continue();
                    break;
                case "Пауза":
                    Pause();
                    break;
            }
        }

        public class Model
        {
            private double[][] Q = {new double[]{-0.5, 0, 0.65, 0.35},
                                    new double[]{-0.7, 0.2, 0, 0.8 },
                                    new double[]{-0.4, 0.45, 0.55, 0 }};
            private Random rand = new Random();
            public List<Weather> stat; public List<double> time;
            public double[] state_time;
            public double t, dt = 1;

            public void Init()
            {
                t = 0;
                stat = new List<Weather> { Weather.clear };
                time = new List<double> { 0 };
                state_time = new double[3] { 0, 0, 0 };
                AddState();
            }

            public void Next()
            {
                t += dt;
                while (time[time.Count - 1] <= t)
                {
                    AddState();
                }
            }

            private void AddState()
            {
                int currentState = (int)stat[stat.Count - 1];
                double tau = Math.Log(rand.NextDouble()) / Q[currentState][0];
                state_time[currentState] += tau;
                time.Add(time[time.Count - 1] + tau);
                stat.Add(GenerateState(Q[currentState]));
            }

            private Weather GenerateState(double[] prob)
            {
                var value = rand.NextDouble(); int i = 1;
                while (prob[i] <= value)
                {
                    value -= prob[i++];
                }

                return (Weather)(i - 1);
            }
        }
        private Model model;
        public enum Weather
        {
            clear = 0, cloudy = 1, rainy = 2
        }

        private void InitFormAndModel()
        {
            model.Init();
            UpdateForm();
        }

        private void UpdateForm()
        {
            var time = (int)Math.Ceiling(model.t * 10);

            lbWeather.Text = GetLabel(model.stat[model.stat.Count - 2]);
            lbDay.Text = $"{time / 100}.{time % 100}";
            lbClear.Text = (100 * model.state_time[0] / model.time[model.time.Count - 1]).ToString("f1");
            lbCloudy.Text = (100 * model.state_time[1] / model.time[model.time.Count - 1]).ToString("f1");
            lbRainy.Text = (100 * model.state_time[2] / model.time[model.time.Count - 1]).ToString("f1");
        }

        private string GetLabel(Weather state)
        {
            switch (state)
            {
                case Weather.clear: return "Ясно :)";
                case Weather.cloudy: return "Облачно :|";
                case Weather.rainy: return "Дождь :(";
            }
            return "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            model.Next();
            UpdateForm();
        }
    }
}
