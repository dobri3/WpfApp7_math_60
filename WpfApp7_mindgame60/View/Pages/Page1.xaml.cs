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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool A = true;
            bool B = false;
            bool C = false;
            MessageBox.Show($"a) A = 1, B = 0, C = 0.   {(A || !A && B) || C}");
            MessageBox.Show($"б) A = 1, B = 0, C = 0.   {!A || A && (B || C)}");
            MessageBox.Show($"в) A = 1, B = 0, C = 0.   {(A || B && !C) || C}");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool Y = true;
            bool X = false;
            bool Z = false;
            MessageBox.Show($"a) Y = 1, X = 0, Z = 0.   {X && !(Z || Y) || !Z}");
            MessageBox.Show($"б) Y = 1, X = 0, Z = 0.   {!X || X && (Y || Z)}");
            MessageBox.Show($"в) Y = 1, X = 0, Z = 0.   {(X || Y && !Z) && Z}");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int x = 2;
            int y = 1;
            MessageBox.Show($"a) x = 2, y = 1;   {(!(x * y < 0)) && (y > x)}");
            int y1 = -2;
            MessageBox.Show($"a) x = 2, y = -2;   {(x >= 2) || (Math.Pow(y1, 2) != 5)}");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{(Convert.ToDouble(Tb_1_4) % 2 == 0) || (Convert.ToDouble(Tb_1_4) % 3 == 0)}");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{(Convert.ToDouble(TbA_1_5) % 2 != 0) || (Convert.ToDouble(TbB_1_5) % 2 != 0)}");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            bool x = false;
            bool y = false;
            bool z = true;
            MessageBox.Show($"a) {x || y && !z}");
            MessageBox.Show($"б) {!x && !y}");
            MessageBox.Show($"в) {!(x && y) || y}");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"a) {Convert.ToDouble(TbY_1_7) == 2}");
            MessageBox.Show($"б) {Convert.ToDouble(TbY_1_7) == 2}");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int x = 1;
            int y = 2;
            MessageBox.Show($"a) {(x >= 0) && (Math.Pow(y, 2) != 4)}");
            int x1 = 2;
            int y1 = 1;
            MessageBox.Show($"б) {(x1 * y1 != 0) || (y > x)}");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int x = 1;
            int y = 2;
            MessageBox.Show($"a) {(!(x * y < 0)) || (y > x)}");
            int x1 = 2;
            int y1 = 1;
            MessageBox.Show($"б) {(x1 * y1 != 0) && (y1 < x1)}");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            bool A = true;
            bool B = false;
            bool C = true;
            MessageBox.Show($"a)    {A || !(A && B) || C}");
            MessageBox.Show($"б)    {!A || C && !(B || C)}");
            MessageBox.Show($"в)    {(A || B && !C) || A}");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            int x = 1;
            int y = 2;
            MessageBox.Show($"a) {(!(x * y < 1) && (y > x))}");
            int x1 = 1;
            int y1 = 2;
            MessageBox.Show($"б) {(x1 * y1 != 0) || (y1 < x1)}");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Convert.ToDouble(TbY_1_12) % 100 > 1 && Convert.ToDouble(TbY_1_12) % 100 < 10}");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{(Convert.ToDouble(TbA_1_13) < 45 && Convert.ToDouble(TbB_1_13) >= 45 && Convert.ToDouble(TbC_1_13) >= 45) || (Convert.ToDouble(TbA_1_13) >= 45 && Convert.ToDouble(TbB_1_13) < 45 && Convert.ToDouble(TbC_1_13) >= 45) || (Convert.ToDouble(TbA_1_13) >= 45 && Convert.ToDouble(TbB_1_13) >= 45 && Convert.ToDouble(TbC_1_13) < 45)}");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Convert.ToDouble(TbY_1_14) % 3 == 0 && Convert.ToDouble(TbY_1_14) % 10 == 0}");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{((Convert.ToDouble(TbY_1_15) < -51) && (Convert.ToDouble(TbY_1_15) > -137)) || ((Convert.ToDouble(TbY_1_15) < 123) && (Convert.ToDouble(TbY_1_15) > 55))}");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{((Convert.ToDouble(TbY_1_16) % 5 == 0) && (Convert.ToDouble(TbX_1_16) % 5 != 0) && (Convert.ToDouble(TbZ_1_16) % 5 != 0)) || ((Convert.ToDouble(TbY_1_16) % 5 != 0) && (Convert.ToDouble(TbX_1_16) % 5 == 0) && (Convert.ToDouble(TbZ_1_16) % 5 != 0)) || ((Convert.ToDouble(TbY_1_16) % 5 != 0) && (Convert.ToDouble(TbX_1_16) % 5 != 0) && (Convert.ToDouble(TbZ_1_16) % 5 == 0))}");
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{(Convert.ToDouble(TbY_1_17) > 80) || (Convert.ToDouble(TbX_1_17) > 80) || (Convert.ToDouble(TbZ_1_17) > 80)}");
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            bool a = true;
            bool b = false;
            bool c = false;
            MessageBox.Show($"a) {a && !b || c}");
            MessageBox.Show($"б) {a && (!b || c)}");
            MessageBox.Show($"в) {a || (!(b && c))}");
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            bool a = false;
            bool b = false;
            bool c = true;
            MessageBox.Show($"a) {(!a || !b) && !c}");
            MessageBox.Show($"б) {(!a || !b) && (a || b)}");
            MessageBox.Show($"в) {a && b || a && c || !c}");
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"a) {Convert.ToDouble(TbY_1_20) == 1 - Math.Cos(Convert.ToDouble(TbX_1_20) * 3)}");
            MessageBox.Show($"б) {Convert.ToDouble(TbY_1_20) == Convert.ToDouble(TbX_1_20) / Math.Pow(Convert.ToDouble(TbX_1_20) - 3, 2)}");
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            bool x = false;
            bool y = false;
            bool z = true;
            MessageBox.Show($"a) {(x && !y) || z}");
            MessageBox.Show($"б) {x && (!y || z)}");
            MessageBox.Show($"в) {x || (!(y || z))}");
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"a) {(!(Convert.ToDouble(TbX_1_22) <= -5)) && (Convert.ToDouble(TbX_1_22) > 5)}");
            MessageBox.Show($"б) {((Convert.ToDouble(TbY_1_22) > -3.5) && (Convert.ToDouble(TbY_1_22) <= 8.1)) && (Convert.ToDouble(TbX_1_22) != 0)}");
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{(!(Convert.ToDouble(TbY_1_23) > -10) && (Convert.ToDouble(TbY_1_23) < -1)) || ((Convert.ToDouble(TbY_1_23) > 2) && (Convert.ToDouble(TbY_1_23) < 15))}");
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{(Convert.ToDouble(TbY_1_24) % 1000 >= 1) && (Convert.ToDouble(TbY_1_24) % 1000 < 10) && (Convert.ToDouble(TbY_1_24) != 4999)}");
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(TbA_1_25) / Convert.ToDouble(TbB_1_25) > Convert.ToDouble(TbC_1_25) / Convert.ToDouble(TbD_1_25))
            {
                MessageBox.Show($"A/B > C/D");
            }
            if (Convert.ToDouble(TbA_1_25) / Convert.ToDouble(TbB_1_25) < Convert.ToDouble(TbC_1_25) / Convert.ToDouble(TbD_1_25))
            {
                MessageBox.Show($"A/B < C/D");
            }
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"a) {!((Convert.ToDouble(TbX_1_26) > 0 && Convert.ToDouble(TbX_1_26) < 5))}");
            MessageBox.Show($"б) {(Convert.ToDouble(TbY_1_26) > 0) && (Convert.ToDouble(TbY_1_26) <= 6) && (Convert.ToDouble(TbX_1_26) < 7)}");
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"a) {Convert.ToDouble(TbX_1_27) > 3 || Convert.ToDouble(TbX_1_27) < -1}");
            MessageBox.Show($"б) {(Convert.ToDouble(TbY_1_27) > -4 && Convert.ToDouble(TbY_1_27) <= 2) && (Convert.ToDouble(TbX_1_27) > 0)}");
        }
    }
}
