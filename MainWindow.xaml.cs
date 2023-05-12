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

namespace SobolevPP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            v.Visibility= Visibility.Collapsed;
            frame.Navigate(new UserControl1());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            v.Visibility = Visibility.Collapsed;
            frame.Navigate(new UserControl2());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            v.Visibility = Visibility.Collapsed;
            frame.Navigate(new UserControl3());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            v.Visibility = Visibility.Collapsed;
            frame.Navigate(new UserControl4());
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            v.Visibility = Visibility.Collapsed;
            frame.Navigate(new UserControl5());
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            v.Visibility = Visibility.Collapsed;
            frame.Navigate(new UserControl6());
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
