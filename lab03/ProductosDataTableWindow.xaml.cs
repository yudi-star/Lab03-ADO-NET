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

using System.Data;
using Microsoft.Data.SqlClient;

namespace lab03
{
    public partial class ProductosDataTableWindow : Window
    {
        public ProductosDataTableWindow() => InitializeComponent();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(App.ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            conn.Open();
            adapter.Fill(dataTable);
            conn.Close();

            dgProductos.ItemsSource = dataTable.DefaultView;
        }
    }
}
