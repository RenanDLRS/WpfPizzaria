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

namespace WpfPizzaria.Views
{
    /// <summary>
    /// Interaction logic for FrmPrincipal.xaml
    /// </summary>
    public partial class FrmPrincipal : Window
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Função para fechar janela principal
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a janela?", "WPF Vendas",
                MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        //Função do menu cliente (cadastrar)
        private void CadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastrarCliente frmCliente = new FrmCadastrarCliente();
            frmCliente.ShowDialog();
        }

        private void ListarCliente_Click(object sender, RoutedEventArgs e)
        {
            FrmListarCliente frmListar = new FrmListarCliente();
            frmListar.ShowDialog();
        }

        private void cadastrarBebida_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastrarBebida frmBebida = new FrmCadastrarBebida();
            frmBebida.ShowDialog();
        }

        private void listarBebida_Click(object sender, RoutedEventArgs e)
        {
            FrmListarBebida frmListar = new FrmListarBebida();
            frmListar.ShowDialog();
        }

        private void cadastrarSabor_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastrarSabor frmSabor = new FrmCadastrarSabor();
            frmSabor.ShowDialog();
        }

        private void listarSabor_Click(object sender, RoutedEventArgs e)
        {
            FrmListarSabor frmListar = new FrmListarSabor();
            frmListar.ShowDialog();
        }

        private void CadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastrarFuncionario frmCadastrar = new FrmCadastrarFuncionario();
            frmCadastrar.Show();
        }

        private void cadastrarTamanho_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastrarTamanho frmTamanho = new FrmCadastrarTamanho();
            frmTamanho.ShowDialog();
        }

        private void listarTamanho_Click(object sender, RoutedEventArgs e)
        {
            FrmListarTamanho frmListar = new FrmListarTamanho();
            frmListar.ShowDialog();
        }

        private void FazerPedido_Click(object sender, RoutedEventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.ShowDialog();
        }
    }
}
