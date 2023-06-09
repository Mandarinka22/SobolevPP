﻿using System;
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
    /// Логика взаимодействия для UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        SobolevPPEntities db;
        List<Оплаты> tb;
        public UserControl3()
        {
            InitializeComponent();
            db = new SobolevPPEntities();
            tb = db.Оплаты.ToList();
            tableGrid.ItemsSource = tb;
        }
        private void refreshdatagrid()
        {
            tableGrid.ItemsSource = db.Оплаты.ToList();
            tableGrid.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nw = new Оплаты();
            db.Оплаты.Add(nw);
            add_3 add = new add_3(db, nw);
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
            Оплаты item = tableGrid.SelectedItem as Оплаты;
            Оплаты del = db.Оплаты.Where(d => d.id == item.id).Single();
            db.Оплаты.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Строка успешно удалена!");
            refreshdatagrid();
        }
    }
}
