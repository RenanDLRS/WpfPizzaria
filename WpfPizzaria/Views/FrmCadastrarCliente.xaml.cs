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
        public FrmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text,
                CriadoEm = DateTime.Now
            };

            if (ClienteDAO.CadastrarCliente(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Cliente já cadastrado!!!");
            }           
        }
    }
}
