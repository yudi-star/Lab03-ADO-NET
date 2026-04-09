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
    public partial class BuscarEstudianteWindow : Window
    {
        public BuscarEstudianteWindow() => InitializeComponent();

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            var lista = new List<Estudiante>();

            SqlConnection conn = new SqlConnection(App.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Estudiantes WHERE nombre LIKE @nombre", conn);
            cmd.Parameters.AddWithValue("@nombre", $"%{txtNombre.Text}%");

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Estudiante
                {
                    Id = (int)reader["id"],
                    Nombre = reader["nombre"].ToString(),
                    Apellido = reader["apellido"].ToString(),
                    Edad = (int)reader["edad"]
                });
            }
            reader.Close();
            conn.Close();

            dgResultados.ItemsSource = lista;
        }
    }
}
