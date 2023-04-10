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
    public partial class UserControl2 : UserControl
    {
        SobolevPPEntities db;
        List<Зарплата> tb;
        public UserControl2()
        {
            InitializeComponent();
            db = new SobolevPPEntities();
            tb = db.Зарплата.ToList();
            tableGrid.ItemsSource = tb;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Search = db.Зарплата.ToList();
            Search = Search.Where(x => x.ФИО_сотрудника.ToLower().StartsWith(Search_Box.Text.ToLower())).ToList();
            tableGrid.ItemsSource = Search.ToList();
        }
    }
}
