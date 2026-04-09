using System.Configuration;
using System.Data;
using System.Windows;

namespace lab03
{
    public partial class App : Application
    {

        public static string ConnectionString =
        "Server=localhost\\SQLEXPRESS;Database=Lab03;Integrated Security=True;TrustServerCertificate=True;";
    }
}