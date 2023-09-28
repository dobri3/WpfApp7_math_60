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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7_mindgame60.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click_48(object sender, RoutedEventArgs e)
        {
           
            
                if (Convert.ToDouble(TbA_2_18) == Convert.ToDouble(TbB_2_18) && Convert.ToDouble(TbC_2_18) == Convert.ToDouble(TbB_2_18))
                {
                    MessageBox.Show("равнобедренный");
                }
            
        }

        private void Button_Click_49(object sender, RoutedEventArgs e)
        {
            if (Math.Pow(Convert.ToDouble(TbC_2_19),2) == Math.Pow(Convert.ToDouble(TbA_2_19), 2) + Math.Pow(Convert.ToDouble(TbB_2_19), 2))
            {
                MessageBox.Show("Тройка пифагора");
            }
            if (Math.Pow(Convert.ToDouble(TbA_2_19), 2) == Math.Pow(Convert.ToDouble(TbB_2_19), 2) + Math.Pow(Convert.ToDouble(TbC_2_19), 2))
            {
                MessageBox.Show("Тройка пифагора");
            }
            if (Math.Pow(Convert.ToDouble(TbB_2_19), 2) == Math.Pow(Convert.ToDouble(TbA_2_19), 2) + Math.Pow(Convert.ToDouble(TbC_2_19), 2))
            {
                MessageBox.Show("Тройка пифагора");
            }
        }

        private void Button_Click_50(object sender, RoutedEventArgs e)
        {
            int a = 1; double b = Math.Pow(1/10, 3)/1000*60;
            if (a>b)
            {
                MessageBox.Show("a>b");
            }
            if (a < b)
            {
                MessageBox.Show("a<b");
            }
        }

        private void Button_Click_51(object sender, RoutedEventArgs e)
        {
            double r = Math.Sqrt(Convert.ToDouble(TbA_2_21) / 3.14);
            double a = Math.Sqrt(Convert.ToDouble(TbB_2_21));
            if (2*r > a) 
            {
                MessageBox.Show("Квадрат уместиться в круге");
            }
            if (2 * r < a)
            {
                MessageBox.Show("Круг уместиться в квадрате");
            }
        }

        private void Button_Click_52(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbM1_2_22)/Convert.ToDouble(TbP1_2_22) > Convert.ToDouble(TbM2_2_22) / Convert.ToDouble(TbP2_2_22))
            {
                MessageBox.Show("Плотность первого больше");
            }
            if (Convert.ToDouble(TbM1_2_22) / Convert.ToDouble(TbP1_2_22) < Convert.ToDouble(TbM2_2_22) / Convert.ToDouble(TbP2_2_22))
            {
                MessageBox.Show("Плотность 2 больше");
            }
        }

        private void Button_Click_53(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbA_2_23)*3.6 > Convert.ToDouble(TbB_2_23))
            {
                MessageBox.Show("Превая скотость больше");
            }
            if (Convert.ToDouble(TbA_2_23) * 3.6 < Convert.ToDouble(TbB_2_23))
            {
                MessageBox.Show("2 скотость больше");
            }
        }

        private void Button_Click_55(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbU1_2_25)/ Convert.ToDouble(TbR1_2_25) < Convert.ToDouble(TbU2_2_25) / Convert.ToDouble(TbR2_2_25))
            {
                MessageBox.Show("по 1 протекает наимньший ток");
            }
            if (Convert.ToDouble(TbU1_2_25) / Convert.ToDouble(TbR1_2_25) > Convert.ToDouble(TbU2_2_25) / Convert.ToDouble(TbR2_2_25))
            {
                MessageBox.Show("по 2 протекает наимньший ток");
            }
        }
    }
}
