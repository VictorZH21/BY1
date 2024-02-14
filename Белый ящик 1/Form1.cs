using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Белый_ящик_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    MessageBox.Show("Введите корректные данные. Все стороны треугольника должны быть больше 0.");
                    return;
                }

                if (a + b > c && a + c > b && b + c > a)
                {
                    double p = (a + b + c) / 2;
                    double s1 = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    if (a == b && b == c)
                    {
                        textBox4.Text = $"Треугольник равносторонний. Площадь равна {s1:F2}";
                    }
                    else if (a == b || b == c || a == c)
                    {
                        textBox4.Text = $"Треугольник равнобедренный. Площадь равна {s1:F2}";
                    }
                    else
                    {
                        textBox4.Text = $"Треугольник разносторонний. Площадь равна {s1:F2}";
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректные данные. Сумма двух сторон не может быть меньше третьей стороны.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые данные для сторон треугольника.", "Ошибка ввода");
            }
            catch (Exception)
            {
                MessageBox.Show("Треугольник с такими сторонами не существует.", "Ошибка ввода");
            }
        }
    }
}
