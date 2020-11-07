using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;        
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ApproximationWF
{
    public partial class Form1 : Form
    {
        private decimal[] z = new decimal[0];
        private decimal[] c = new decimal[0];

        public Form1()
        {
            InitializeComponent();
            // настройка графика
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; 
            chart1.Series["Series1"].LegendText = "График f(x)";

            chart1.Series.Add("Series2");
            chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series["Series2"].LegendText = "График Y(x)";

            chart1.Series.Add("Series3");
            chart1.Series["Series3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.Series["Series3"].LegendText = "График f1(x)";

            chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(textBox_minx.Text);
            chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(textBox_maxx.Text);
            chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(textBox_miny.Text);
            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(textBox_maxy.Text);

            int m = Int32.Parse(textBox_m.Text);      // определение c, z, m
            Random rnd = new Random();
            z = new decimal[m];
            c = new decimal[m];
            
            for (int i = 0; i < m; i++)
            {
                z[i] = Convert.ToDecimal(rnd.NextDouble());
                c[i] = Convert.ToDecimal(rnd.Next(1, 6));
            }
        }

        static T[,] Copy<T>(T[,] array)                          // метод ArrayCopy
        {
            T[,] newArray = new T[array.GetLength(0), array.GetLength(1)];    // копирование данных из старого массива в новый
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    newArray[i, j] = array[i, j];
            return newArray;
        }

        private decimal fn(decimal x)
        {
            return Math.Abs(Math.Abs(Math.Abs(x) - 2) - 1);     // исходная функция
        }

        private double fn(double x)
        {
            return Math.Abs(Math.Abs(Math.Abs(x) - 2) - 1);    // перегрузка функции
        }

        private decimal k(decimal z)
        {
            if (z < 0.5M) return -1;     // определение k
            else return 1;
        }

        private decimal PowDecimal(decimal x, int y)    
        {
            decimal res = 1;
            for (int i = 0; i < y; i++)
            {
                res *= x;
            }

            return res;
        }

        private decimal[] Gauss(int n, int m, decimal[,] matrix_original)
        {
            decimal[,] matrix = Copy(matrix_original);

            decimal tmp;
            int k;
            decimal[] xx = new decimal[m];

            for (int i = 0; i < n; i++)    // делаем главную диагональ единицами
            {
                tmp = matrix[i,i];
                for (int j = n; j >= i; j--)
                    matrix[i,j] /= tmp;
                for (int j = i + 1; j < n; j++)  // обнуляем числа под единицами главной диагонали
                {
                    tmp = matrix[j,i];
                    for (k = n; k >= i; k--)
                        matrix[j,k] -= tmp * matrix[i,k];  // отнимаем от строки строку, помноженную на элемент
                }
            }
            /*обратный ход*/
            xx[n - 1] = matrix[n - 1,n];
            for (int i = n - 2; i >= 0; i--)
            {
                xx[i] = matrix[i,n];
                for (int j = i + 1; j < n; j++) xx[i] -= matrix[i,j] * xx[j];
            }

            return xx;
        }

        private decimal Y(double x, decimal[] C, int n)       // определение аппроксиманты
        {
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += C[i] * PowDecimal(Convert.ToDecimal(x), i);
            }

            return sum;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox_n.Text);
            n++;
            int m = Int32.Parse(textBox_m.Text);
            decimal a = Convert.ToDecimal(textBox_a.Text);
            decimal b = Convert.ToDecimal(textBox_b.Text);
            decimal[] x = new decimal[m];
            decimal[] f = new decimal[m];

            for (int i = 0; i < m; i++)
            {
                x[i] = a + Convert.ToDecimal(i) * (b - a) / Convert.ToDecimal(m);
                f[i] = fn(x[i]) * (1 + k(z[i]) * z[i] / c[i]);
            }

            decimal[] D = new decimal[2*n];
            for (int k = 0; k < 2*n; k++)
            {
                decimal sum = 0;
                for (int i = 0; i < m; i++)
                {
                    sum += PowDecimal(x[i], k);
                }

                D[k] = sum;
            }

            decimal[,] A = new decimal[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i,j] = D[i + j];
                }
            }

            decimal[] B = new decimal[n];
            for (int k = 0; k < n; k++)
            {
                decimal sum = 0;
                for (int i = 0; i < m; i++)
                {
                    sum += f[i] * PowDecimal(x[i], k);
                }

                B[k] = sum;
            }

            decimal[,] M = new decimal[n,n+1];     // создаем расширенную матрицу
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = A[i, j];
                }
                M[i, n] = B[i];
            }
            decimal[] C = Gauss(n, n + 1, M);   // результат работы метода Гаусса

            decimal[] delta = new decimal[n];
            for (int i = 0; i < n; i++)
            {
                decimal sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += A[i, j] * C[j];
                }

                delta[i] = sum - B[i];
            }

            decimal S = 0;
            for (int i = 0; i < m; i++)
            {
                S += PowDecimal(Y(Convert.ToDouble(a + Convert.ToDecimal(i) * (b - a) / Convert.ToDecimal(m)), C, n) - f[i], 2);
            }
            Console.WriteLine(S);
       
           

            richTextBox_res.Text = "";    // выводим S
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(delta[i]);
            }
            richTextBox_res.Text = richTextBox_res.Text + (S).ToString() + "\n";



            chart1.Series["Series1"].Points.Clear();  // очищаем графики от старых значений
            chart1.Series["Series2"].Points.Clear();
            chart1.Series["Series3"].Points.Clear();
            for (double i = Convert.ToDouble(a); i <= Convert.ToDouble(b); i += Convert.ToDouble(textBox_step.Text))
            {
                chart1.Series["Series1"].Points.AddXY(i, fn(i));
            }
            for (double i = Convert.ToDouble(a); i <= Convert.ToDouble(b); i += Convert.ToDouble(textBox_step.Text))
            {
                chart1.Series["Series2"].Points.AddXY(i, Y(i, C, n));
            }
            for (int i = 0; i < m; i++)
            {
                chart1.Series["Series3"].Points.AddXY(a + Convert.ToDecimal(i) * (b - a) / Convert.ToDecimal(m), f[i]);
            }

            //Вывод С и delta в файл
            string writePathC = @"C.txt";
            string writePathDelta = @"delta.txt";
            if (System.IO.File.Exists(writePathC))
            {
                System.IO.File.Delete(writePathC);
            }
            if (System.IO.File.Exists(writePathDelta))
            {
                System.IO.File.Delete(writePathDelta);
            }
            using (StreamWriter sw = new StreamWriter(writePathC, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(C[i]);
                }
            }
            using (StreamWriter sw = new StreamWriter(writePathDelta, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(delta[i]);
                }
            }
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_minx_Leave(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(textBox_minx.Text);
        }

        private void textBox_maxx_Leave(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(textBox_maxx.Text);
        }

        private void textBox_miny_Leave(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(textBox_miny.Text);
        }

        private void textBox_maxy_Leave(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(textBox_maxy.Text);
        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void графикFxToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (графикFxToolStripMenuItem.Checked)
            {
                chart1.Series["Series1"].Enabled = true;
            }
            else
            {
                chart1.Series["Series1"].Enabled = false;
            }
        }

        private void графикF1xToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (графикF1xToolStripMenuItem.Checked)
            {
                chart1.Series["Series3"].Enabled = true;
            }
            else
            {
                chart1.Series["Series3"].Enabled = false;
            }
        }

        private void графикYxToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Series2"].Enabled = графикYxToolStripMenuItem.Checked;
        }

        private void textBox_m_Leave(object sender, EventArgs e)
        {
            int m = Int32.Parse(textBox_m.Text);
            Random rnd = new Random();
            z = new decimal[m];
            c = new decimal[m];

            for (int i = 0; i < m; i++)
            {
                z[i] = Convert.ToDecimal(rnd.NextDouble());
                c[i] = Convert.ToDecimal(rnd.Next(1, 6));
            }
        }
    }
}
