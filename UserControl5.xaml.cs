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
    /// Логика взаимодействия для UserControl5.xaml
    /// </summary>
    public partial class UserControl5 : UserControl
    {
        SobolevPPEntities db;
        List<Затраты> tb;
        public UserControl5()
        {
            InitializeComponent();
            db = new SobolevPPEntities();
            tb = db.Затраты.ToList();
            tableGrid.ItemsSource = tb;
        }
        private void refreshdatagrid()
        {
            tableGrid.ItemsSource = db.Затраты.ToList();
            tableGrid.Items.Refresh();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nw = new Затраты();
            db.Затраты.Add(nw);
            add_5 add = new add_5(db, nw);
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
            Затраты item = tableGrid.SelectedItem as Затраты;
            Затраты del = db.Затраты.Where(d => d.id == item.id).Single();
            db.Затраты.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Строка успешно удалена!");
            refreshdatagrid();
        }
    }
}
