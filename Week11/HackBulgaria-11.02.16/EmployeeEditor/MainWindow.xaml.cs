using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;
using System.Data.Entity;

namespace EmployeeEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HackCompanyEntities employee;
        public MainWindow ( )
        {
            InitializeComponent();
            employee = new HackCompanyEntities();
            dataGrid1.DataContext = employee;
        }

        private void Grid_Loaded ( object sender , RoutedEventArgs e )
        {
            var query = from item in employee.Employee
                        select new { item.EmployeeID , item.Name };
            dataGrid1.ItemsSource = query.ToList();
        }
    }
}
