using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void BtnEstDataTable_Click(object sender, RoutedEventArgs e)
            => new EstudiantesDataTableWindow().ShowDialog();

        private void BtnEstReader_Click(object sender, RoutedEventArgs e)
            => new EstudiantesReaderWindow().ShowDialog();

        private void BtnBuscarEst_Click(object sender, RoutedEventArgs e)
            => new BuscarEstudianteWindow().ShowDialog();

        private void BtnProdDataTable_Click(object sender, RoutedEventArgs e)
            => new ProductosDataTableWindow().ShowDialog();

        private void BtnProdReader_Click(object sender, RoutedEventArgs e)
            => new ProductosReaderWindow().ShowDialog();

        private void BtnBuscarProd_Click(object sender, RoutedEventArgs e)
            => new BuscarProductoWindow().ShowDialog();
    }

}