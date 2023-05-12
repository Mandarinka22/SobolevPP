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

namespace SobolevPP
{
    /// <summary>
    /// Логика взаимодействия для add_4.xaml
    /// </summary>
    public partial class add_4 : Window
    {
        SobolevPPEntities db;
        public add_4(SobolevPPEntities db,  Зарплата c)
        {
            InitializeComponent();
            this.db = db;
            this.DataContext = c;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Строка успешно добавлена!");
            db.SaveChanges();
            this.Close();
        }
    }
}
