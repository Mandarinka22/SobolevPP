using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace SobolevPP
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SobolevPPEntities db = new SobolevPPEntities();
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = loginbox.Text;
            string pass = passbox.Password;

            if (db.Авторизация.Any(u => u.Логин == login && u.Пароль == pass))

            {
                foreach (var client in db.Авторизация)
                {
                    if (client.Логин == login && client.Пароль == pass)

                    {


                        this.Visibility = Visibility.Collapsed;
                        MainWindow MW = new MainWindow();
                        MW.Show();

                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
        }
    }
}
