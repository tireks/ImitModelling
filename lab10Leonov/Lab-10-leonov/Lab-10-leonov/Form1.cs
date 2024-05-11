using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10_leonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = tableProbData.Rows.Count - 1;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            double[] lambda = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                lambda[i] = Convert.ToDouble(tableProbData.Rows[i].Cells[1].Value);
                tableProbData.Rows[i].Cells[2].Value = 0;
                tableProbData.Rows[i].Cells[3].Value = 0;
                tableProbData.Rows[i].Cells[4].Value = 0;
                tableProbData.Rows[i].Cells[5].Value = 0;
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < rows - 1; j++)
                {
                    int leftTeam = 0;
                    double S = 0f;
                    double a = 0f;

                    while (S >= -lambda[j])
                    {
                        a = rand.NextDouble();

                        S += Math.Log(a);

                        if (S >= -lambda[j]) leftTeam++;
                    }

                    for (int k = j + 1; k < rows; k++)
                    {
                        int rightTeam = 0;
                        S = 0f;
                        a = 0f;

                        while (S >= -lambda[k])
                        {
                            a = rand.NextDouble();

                            S += Math.Log(a);

                            if (S >= -lambda[k]) rightTeam++;
                        }

                        int lTeamPoints = Convert.ToInt32(tableProbData.Rows[j].Cells[5].Value);
                        int rTeamPoints = Convert.ToInt32(tableProbData.Rows[k].Cells[5].Value);

                        if (leftTeam > rightTeam)
                        {
                            lTeamPoints += 3;
                            tableProbData.Rows[j].Cells[2].Value = Convert.ToInt32(tableProbData.Rows[j].Cells[2].Value) + 1;
                            tableProbData.Rows[k].Cells[3].Value = Convert.ToInt32(tableProbData.Rows[k].Cells[3].Value) + 1;
                        }
                        else if (rightTeam > leftTeam)
                        {
                            rTeamPoints += 3;
                            tableProbData.Rows[j].Cells[3].Value = Convert.ToInt32(tableProbData.Rows[j].Cells[3].Value) + 1;
                            tableProbData.Rows[k].Cells[2].Value = Convert.ToInt32(tableProbData.Rows[k].Cells[2].Value) + 1;
                        }
                        else if (leftTeam == rightTeam)
                        {
                            lTeamPoints++;
                            rTeamPoints++;

                            tableProbData.Rows[j].Cells[4].Value = Convert.ToInt32(tableProbData.Rows[j].Cells[4].Value) + 1;
                            tableProbData.Rows[k].Cells[4].Value = Convert.ToInt32(tableProbData.Rows[k].Cells[4].Value) + 1;
                        }
                        tableProbData.Rows[j].Cells[5].Value = lTeamPoints;
                        tableProbData.Rows[k].Cells[5].Value = rTeamPoints;
                    }
                }
            }
            tableProbData.Sort(Points, ListSortDirection.Descending);
        }
    }
}
