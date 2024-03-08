using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Leonov
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private bool[,] field;
        private int resolution, rows, columns;

        private void timer_Tick(object sender, EventArgs e)
        {
            theNextGeneration();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStopStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            if (timer.Enabled == true) startGame();
            else
            {
                editResolution.Enabled = true;
                editDensity.Enabled = true;
            }
        }

        private void theNextGeneration()
        {
            g.Clear(Color.Black);  //заливаем экран чёрным цветом
            var newField = new bool[columns, rows];  //создаём новое поле

            for (int x = 0; x < columns; x++)  //смотрим наличие живых и мертвых соседних клеток
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighbours = countNeighbours(x, y);  //вызываем метод подсчёта соседей
                    var hasLife = field[x, y];  //есть ли живая клетка по координатам х и у 

                    if (!hasLife && neighbours == 3) //если нет жизни и 3 соседа, то жизнь возможна
                    {
                        newField[x, y] = true;
                    }
                    else if (hasLife && (neighbours < 2 || neighbours > 3)) //клетка умирает
                    {
                        newField[x, y] = false;
                    }
                    else //остаётся то же самое
                    {
                        newField[x, y] = hasLife;
                    }

                    if (hasLife)
                    {
                        g.FillRectangle(Brushes.Purple, x * resolution,  //рисуем живые клеточки, сдвигая по нужным координатам
                            y * resolution, resolution - 1, resolution - 1);
                    }
                }
            }
            field = newField;
            pictureBox1.Refresh();  //перерисовываем поле
        }

        private void startGame()
        {
            editResolution.Enabled = false; //делаем неактивными поля ввода значений разрешение и плотность
            editDensity.Enabled = false;
            resolution = (int)editResolution.Value; //считываем значение разрешения
            rows = pictureBox1.Height / resolution;  //определяем размер поля в клетках
            columns = pictureBox1.Width / resolution;
            field = new bool[columns, rows];  //создаём поле
            Random random = new Random();
            for (int x = 0; x < columns; x++)  //создаём первое поколение клеток в поле
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)editDensity.Value) == 0;  //случайным образом определяем элементы
                }
            }
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);  //инициализируем картинку
            g = Graphics.FromImage(pictureBox1.Image);  //теперь можем отрисовывать фигуры на пикчербоксе
        }

        private int countNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + columns) % columns;  //смотрим на все близлежайшие клетки
                    var row = (y + j + rows) % rows;
                    var self = col == x && row == y;  //проверяем сами себя
                    var isAlive = field[col, row];
                    if (isAlive && !self) count++; // считаем всех живых соседей 
                }
            }
            return count; //возващаем кол-во живых соседей
        }
    }



}
