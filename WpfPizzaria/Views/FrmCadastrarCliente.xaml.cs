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
    /// Interaction logic for FrmCadastrarCliente.xaml
    /// </summary>
    public partial class FrmCadastrarCliente : Window
    {
        Cliente c = null;

        public FrmCadastrarCliente()
        {
            InitializeComponent();
            txtData.Text = DateTime.Now.ToString();
        }

        public FrmCadastrarCliente(Cliente cliente)
        {
            InitializeComponent();
            btnCadastrar.Content = "Alterar";

            txtData.Text = cliente.CriadoEm.ToString();
            txtCpf.Text = cliente.Cpf.ToString();
            txtEndereco.Text = cliente.Endereco;
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;

            c = cliente;
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            if (c == null)
            {
                c = new Cliente();
                c.Nome = txtNome.Text;
                c.Cpf = txtCpf.Text;
                c.Telefone = txtTelefone.Text;
                c.Endereco = txtEndereco.Text;
                c.CriadoEm = DateTime.Now;

                if (ClienteDAO.CadastrarCliente(c))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso", "Cadastrado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cliente já cadastrado!!!", "Já cadastrado", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

                c = null;
            }
            else if (c != null)
            {
                c.Nome = txtNome.Text;
                c.Cpf = txtCpf.Text;
                c.Telefone = txtTelefone.Text;
                c.Endereco = txtEndereco.Text;

                if (ClienteDAO.AlterarCliente(c))
                {
                    MessageBox.Show("Cliente alterado com sucesso", "Alterado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Erro na alteração!!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
