using System.Configuration;
using System.Windows;

namespace ConexcionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string MiConexion = ConfigurationManager.ConnectionStrings["ConexcionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
        }
    }
}
