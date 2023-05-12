using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
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
    /// Логика взаимодействия для UserControl6.xaml
    /// </summary>
    public partial class UserControl6 : UserControl
    {
        SobolevPPEntities db;
        List<Отчет> tb;
        public UserControl6()
        {
            InitializeComponent();
            db = new SobolevPPEntities();
            tb = db.Отчет.ToList();
            tableGrid.ItemsSource = tb;
            /*tableGrid.ItemsSource = GetReportData();*/

        }
       /* public class ReportViewModel
        {
            public int Id { get; set; }
            public decimal TotalExpenses { get; set; }
            public decimal TotalSalary { get; set; }
            public decimal TotalPayments { get; set; }
        }
        public List<ReportViewModel> GetReportData()
        {

            using (var connection = new EntityConnection("name=SobolevPPEntities"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
            SELECT 
                r.id,
                SUM(e.Сумма) AS TotalExpenses,
                SUM(z.Сумма) AS TotalSalary,
                SUM(o.Сумма) AS TotalPayments
            FROM 
                Отчет r
                JOIN Затраты e ON r.id_затрат = e.id
                JOIN Зарплата z ON r.id_зарплаты = z.id
                JOIN Оплаты o ON r.id_оплаты = o.id
            GROUP BY 
                r.id
            ORDER BY 
                r.id";

                var reportData = new List<ReportViewModel>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var reportViewModel = new ReportViewModel
                        {
                            Id = reader.GetInt32(0),
                            TotalExpenses = reader.GetDecimal(1),
                            TotalSalary = reader.GetDecimal(2),
                            TotalPayments = reader.GetDecimal(3),
                        };

                        reportData.Add(reportViewModel);
                    }
                }

                return reportData;
            }
        }*/

        private void tableGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
