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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        SobolevPPEntities db;
        List<Клиенты> tb;
        public UserControl1()
        {
            InitializeComponent();
            db = new SobolevPPEntities();
            tb = db.Клиенты.ToList();
            tableGrid.ItemsSource = tb;
        }

        private void refreshdatagrid()
        {
            tableGrid.ItemsSource = db.Клиенты.ToList();
            tableGrid.Items.Refresh();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Search = db.Клиенты.ToList();
            Search = Search.Where(x => x.ФИО.ToLower().StartsWith(Search_Box.Text.ToLower())).ToList();
            tableGrid.ItemsSource = Search.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nw = new Клиенты();
            db.Клиенты.Add(nw);
            add_1 add = new add_1(db, nw);
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
            Клиенты item = tableGrid.SelectedItem as Клиенты;
            Клиенты del = db.Клиенты.Where(d => d.id == item.id).Single();
            db.Клиенты.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Строка успешно удалена!");
            refreshdatagrid();
        }
    }
}
