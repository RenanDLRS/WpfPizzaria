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
using WpfPizzaria.Models;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastrarBebida frmCadastrarBebida = new FrmCadastrarBebida((Bebida)dtaBebidas.SelectedValue);
            frmCadastrarBebida.ShowDialog();

            dtaBebidas.Items.Refresh();
        }

        private void BtnDeletar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmar exclusão", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                BebidaDAO.DeletarBebida((Bebida)dtaBebidas.SelectedValue);
            }

            dtaBebidas.Items.Refresh();
        }
    }
}
