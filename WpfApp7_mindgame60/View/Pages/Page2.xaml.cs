using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp7_mindgame60.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Convert.ToDouble(TbY_1_28) == 1 / Math.Pow(Convert.ToDouble(TbX_1_28) - 3, 2)}");
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Convert.ToDouble(TbY_1_29) == 1 / (Math.Tan(2 * Convert.ToDouble(TbX_1_29)))}");
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Convert.ToDouble(TbY_1_30) == 1 / Math.Pow(Convert.ToDouble(TbX_1_30), 2)}");
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            if (Math.Pow(Convert.ToDouble(TbY_2_1), 2) + Math.Pow(Convert.ToDouble(TbX_2_1), 2) > Math.Pow(Convert.ToDouble(TbY_2_1) + Convert.ToDouble(TbX_2_1), 2))
            {
                MessageBox.Show("Сумма квадратов больше");
            }

            if (Math.Pow(Convert.ToDouble(TbY_2_1), 2) + Math.Pow(Convert.ToDouble(TbX_2_1), 2) < Math.Pow(Convert.ToDouble(TbY_2_1) + Convert.ToDouble(TbX_2_1), 2))
            {
                MessageBox.Show("Квадрат суммы больше");
            }

        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbX_2_2) >= 2 && Convert.ToDouble(TbX_2_2) <= 5)
            {
                MessageBox.Show($"{Convert.ToDouble(TbY_2_2) * 1,02}");
            }

            if (Convert.ToDouble(TbX_2_2) >= 5 && Convert.ToDouble(TbX_2_2) <= 10)
            {
                MessageBox.Show($"{Convert.ToDouble(TbY_2_2) * 1,05}");
            }
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            if ((Convert.ToDouble(TbY_2_3_0) - Convert.ToDouble(TbY_2_3_1)) + (Convert.ToDouble(TbX_2_3_0) - Convert.ToDouble(TbX_2_3_1)) > 0)
            {
                MessageBox.Show($"A более удалена.");
            }
            if ((Convert.ToDouble(TbY_2_3_0) - Convert.ToDouble(TbY_2_3_1)) + (Convert.ToDouble(TbX_2_3_0) - Convert.ToDouble(TbX_2_3_1)) < 0)
            {
                MessageBox.Show($"B более удалена.");
            }
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            if (Math.Pow(Convert.ToDouble(TbC_2_4), 2) == Math.Pow(Convert.ToDouble(TbA_2_4), 2) + Math.Pow(Convert.ToDouble(TbB_2_4), 2))
            {
                MessageBox.Show($"Треугольник прямоугольный");
            }
        }

        private void Button_Click_35(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbA_2_5) > 0)
            {
                MessageBox.Show($"{Math.Pow(Convert.ToDouble(TbA_2_5), 2)}");
            }
            if (Convert.ToDouble(TbB_2_5) < 0)
            {
                MessageBox.Show($"{Math.Pow(Convert.ToDouble(TbB_2_5), 2)}");
            }
            if (Convert.ToDouble(TbC_2_5) > 0)
            {
                MessageBox.Show($"{Math.Pow(Convert.ToDouble(TbC_2_5), 2)}");
            }
        }

        private void Button_Click_36(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbY_2_6) > 0 && Convert.ToDouble(TbX_2_6) > 0)
            {
                MessageBox.Show("A лежит в 1 четверти");
            }
            if (Convert.ToDouble(TbY_2_6) > 0 && Convert.ToDouble(TbX_2_6) < 0)
            {
                MessageBox.Show("A лежит в 4 четверти");

                if (Convert.ToDouble(TbY_2_6) < 0 && Convert.ToDouble(TbX_2_6) < 0)
                {
                    MessageBox.Show("A лежит в 3 четверти");
                }
                if (Convert.ToDouble(TbY_2_6) < 0 && Convert.ToDouble(TbX_2_6) > 0)
                {
                    MessageBox.Show("A лежит в 2 четверти");
                }
            }
        }

        private void Button_Click_37(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbY_2_7) < Convert.ToDouble(TbR_2_7) && Convert.ToDouble(TbX_2_7) < Convert.ToDouble(TbR_2_7))
            {
                MessageBox.Show("Лежит внутри окружности");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_39(object sender, RoutedEventArgs e)
        {
            if (Math.Pow(Convert.ToDouble(TbA_2_9), 2) > 2 * 3.14 * Convert.ToDouble(TbR_2_9))
            {
                MessageBox.Show("Площадь квадрата больше");
            }
            if (Math.Pow(Convert.ToDouble(TbA_2_9), 2) < 2 * 3.14 * Convert.ToDouble(TbR_2_9))
            {
                MessageBox.Show("Площадь круга больше");
            }
        }

        private void Button_Click_40(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbA_2_5) > 0)
            {
                MessageBox.Show($"{Math.Pow(Convert.ToDouble(TbA_2_5), 2)}");
            }
            if (Convert.ToDouble(TbB_2_5) > 0)
            {
                MessageBox.Show($"{Math.Pow(Convert.ToDouble(TbB_2_5), 2)}");
            }
            if (Convert.ToDouble(TbC_2_5) > 0)
            {
                MessageBox.Show($"{Math.Pow(Convert.ToDouble(TbC_2_5), 2)}");
            }
            if (Convert.ToDouble(TbA_2_5) < 0)
            {
                MessageBox.Show($"0");
            }
            if (Convert.ToDouble(TbB_2_5) < 0)
            {
                MessageBox.Show($"0");
            }
            if (Convert.ToDouble(TbC_2_5) < 0)
            {
                MessageBox.Show($"0");
            }
        }

        private void Button_Click_41(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbA_2_11) % 3 == 0)
            {
                MessageBox.Show("оканчивается на три");
            }
            if (Convert.ToDouble(TbA_2_11) % 2 == 0)
            {
                MessageBox.Show("четное");
            }
        }

        private void Button_Click_42(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbY_2_12) > 0 && Convert.ToDouble(TbX_2_12) > 0)
            {
                MessageBox.Show("Лежит в первой четверти");
            }
        }

        private void Button_Click_43(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbX_2_13) == 6)
            {
                MessageBox.Show($"{Convert.ToDouble(TbY_2_13)*1,06 / 2}");
            }
            if (Convert.ToDouble(TbX_2_13) == 12)
            {
                MessageBox.Show($"{Convert.ToDouble(TbY_2_13) *1,08}");
            }
        }

        private void Button_Click_44(object sender, RoutedEventArgs e)
        {
            if (Math.Pow(Convert.ToDouble(TbX_2_14),2) - Math.Pow(Convert.ToDouble(TbY_2_14),2) > Math.Abs(Math.Pow(Convert.ToDouble(TbX_2_14) - Convert.ToDouble(TbY_2_14), 2)))
            {
                MessageBox.Show($"Разность квадратов больше");
            }
            if (Math.Pow(Convert.ToDouble(TbX_2_14), 2) - Math.Pow(Convert.ToDouble(TbY_2_14), 2) < Math.Abs(Math.Pow(Convert.ToDouble(TbX_2_14) - Convert.ToDouble(TbY_2_14), 2)))
            {
                MessageBox.Show($"Модуль квадрата разности больше");
            }
        }

        private void Button_Click_46(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbY_2_16)<Convert.ToDouble(TbR_2_16) && Convert.ToDouble(TbY_2_16)> Convert.ToDouble(Tbr_2_16) && Convert.ToDouble(TbX_2_16) < Convert.ToDouble(TbR_2_16) && Convert.ToDouble(TbX_2_16) > Convert.ToDouble(Tbr_2_16))
            {
                MessageBox.Show("Все хорошо");
            }
        }

        private void Button_Click_47(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbY_2_17) < 0 && Convert.ToDouble(TbX_2_17) > 0)
            {
                MessageBox.Show("Лежит в 4 четверти");
            }
        }



        private void Button_Click_NextPage3(object sender, RoutedEventArgs e)
        {

        }

        
    }
}

