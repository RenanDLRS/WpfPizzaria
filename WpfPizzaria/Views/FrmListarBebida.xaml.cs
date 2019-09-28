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
using WpfPizzaria.DAL;

namespace WpfPizzaria.Views
{
    /// <summary>
    /// Interaction logic for FrmListarBebida.xaml
    /// </summary>
    public partial class FrmListarBebida : Window
    {
        public FrmListarBebida()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaBebidas.ItemsSource = BebidaDAO.ListarBebidas();
        }
    }
}
