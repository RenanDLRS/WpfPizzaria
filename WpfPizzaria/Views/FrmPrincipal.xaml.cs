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

        private void CadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastrarFuncionario frmFuncionario = new FrmCadastrarFuncionario();
            frmFuncionario.ShowDialog();
        }
    }
}
