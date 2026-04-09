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

using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace lab03
{
    public partial class BuscarProductoWindow : Window
    {
        public BuscarProductoWindow() => InitializeComponent();

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            var lista = new List<Producto>();

            SqlConnection conn = new SqlConnection(App.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Productos WHERE precio BETWEEN @min AND @max", conn);
            cmd.Parameters.AddWithValue("@min", decimal.Parse(txtMin.Text));
            cmd.Parameters.AddWithValue("@max", decimal.Parse(txtMax.Text));

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Producto
                {
                    Id = (int)reader["id"],
                    Nombre = reader["nombre"].ToString(),
                    Precio = (decimal)reader["precio"],
                    Stock = (int)reader["stock"]
                });
            }
            reader.Close();
            conn.Close();

            dgResultados.ItemsSource = lista;
        }
    }
}
