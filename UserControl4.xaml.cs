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
    /// Логика взаимодействия для UserControl2.xaml
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        SobolevPPEntities db;
        List<Зарплата> tb;
        public UserControl4()
        {
            InitializeComponent();
            db = new SobolevPPEntities();
            tb = db.Зарплата.ToList();
            tableGrid.ItemsSource = tb;
        }
        private void refreshdatagrid()
        {
            tableGrid.ItemsSource = db.Зарплата.ToList();
            tableGrid.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nw = new Зарплата();
            db.Зарплата.Add(nw);
            add_4 add = new add_4(db, nw);
            add.ShowDialog();
            refreshdatagrid();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            refreshdatagrid();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            db = new SobolevPPEntities();
            Зарплата item = tableGrid.SelectedItem as Зарплата;
            Зарплата del = db.Зарплата.Where(d => d.id == item.id).Single();
            db.Зарплата.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Строка успешно удалена!");
            refreshdatagrid();
        }
    }
}

