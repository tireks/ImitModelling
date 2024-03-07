using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Leonov
{
    public partial class Form1 : Form
    {

        private int rows = 1, columns = 15; // начальное кол-во строк и столбцов
        private char[] rule = new char[8];
        private string[] Rules = new string[] {
            "111",
            "110",
            "101",
            "100",
            "011",
            "010",
            "001",
            "000"
        };

        private bool edit = true;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < columns; i++) dataGridView1.Columns.Add("", "");
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].HeaderCell.Value = rows.ToString();
            initializerule(Convert.ToString((int)editRule.Value, 2));
        }

        private void initializerule(string pravilo)
        {
            int l = pravilo.Length;
            while (l < 8)
            {
                pravilo = "0" + pravilo;
                l = pravilo.Length;
            }
            for (int i = 0; i < pravilo.Length; i++)
            {
                rule[i] = pravilo[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            if (timer.Enabled == false) edit = false;
        }

        private void editRule_ValueChanged(object sender, EventArgs e)
        {
            initializerule(Convert.ToString((int)editRule.Value, 2));
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (edit)
            {
                if (e.Button == MouseButtons.Left)
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Pink;
                    dataGridView1.ClearSelection();
                }
                else
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            char[] oldRow = new char[columns];
            char[] newRow = new char[columns];
            for (int i = 0; i < columns; i++)
            {
                if (dataGridView1[i, rows - 1].Style.BackColor == Color.Pink) oldRow[i] = '1';
                else oldRow[i] = '0';
            }
            for (int i = 0; i < columns; i++)
            {
                string Rule;
                int previousNum = i - 1;
                int nextNum = i + 1;
                var builder = new StringBuilder();

                if (i == 0)
                {
                    previousNum = columns - 1;
                }
                if (i == columns - 1)
                {
                    nextNum = 0;
                }

                builder.Append(oldRow[previousNum]);  //Добавляет строковое представление указанного построителя строки к данному экземпляру.
                builder.Append(oldRow[i]);
                builder.Append(oldRow[nextNum]);

                Rule = builder.ToString();
                int index = Array.IndexOf(Rules, Rule);
                newRow[i] = rule[index];
            }

            rows++;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[rows - 1].HeaderCell.Value = rows.ToString();

            for (int i = 0; i < columns; i++)
            {
                if (newRow[i] == '1') dataGridView1[i, rows - 1].Style.BackColor = Color.Pink;
                else dataGridView1[i, rows - 1].Style.BackColor = Color.White;
            }
        }
    }
}
