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
using WpfApp7_mindgame60.Core;
using WpfApp7_mindgame60.View.Pages;

namespace WpfApp7_mindgame60
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            MainCore.MainFrameCore = MainFrame;
            MainFrame.Navigate(new Page1());

        }

        


        private void button_upto1_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page1());
        }
        private void button_upto2_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page2());
        }
        private void button_upto3_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page3());
        }
    }
}
