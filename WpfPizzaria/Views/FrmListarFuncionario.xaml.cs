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
    /// Interaction logic for FrmListarFuncionario.xaml
    /// </summary>
    public partial class FrmListarFuncionario : Window
    {
        public FrmListarFuncionario()
        {
            InitializeComponent();
        }

        private void FrmListarFuncionario_Loaded(object sender, RoutedEventArgs e)
        {
            dtaFuncionarios.ItemsSource = FuncionarioDAO.ListarFuncionarios();
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastrarFuncionario frmCadastrarFuncionario = new FrmCadastrarFuncionario((Funcionario)dtaFuncionarios.SelectedValue);
            frmCadastrarFuncionario.ShowDialog();

            dtaFuncionarios.Items.Refresh();
        }

        private void BtnDeletar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmar exclusão", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                FuncionarioDAO.DeletarFuncionario((Funcionario)dtaFuncionarios.SelectedValue);
            }

            dtaFuncionarios.Items.Refresh();
        }
    }
}
