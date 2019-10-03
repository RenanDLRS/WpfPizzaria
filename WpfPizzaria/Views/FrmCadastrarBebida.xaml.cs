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
    /// Interaction logic for FrmCadastrarBebida.xaml
    /// </summary>
    public partial class FrmCadastrarBebida : Window
    {
        Bebida b = null;

        public FrmCadastrarBebida()
        {
            InitializeComponent();
            txtData.Text = DateTime.Now.ToString();
        }

        public FrmCadastrarBebida(Bebida bebida)
        {
            InitializeComponent();
            btnCadastrar.Content = "Alterar";

            txtNome.Text = bebida.Nome;
            txtPreco.Text = bebida.Preco.ToString();
            txtData.Text = bebida.CriadoEm.ToString();

            b = bebida;
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (b == null)
            {
                b = new Bebida();
                b.Nome = txtNome.Text;
                b.Preco = Convert.ToDouble(txtPreco.Text);
                b.CriadoEm = DateTime.Now;

                if (BebidaDAO.CadastrarBebida(b))
                {
                    MessageBox.Show("Bebida cadastrado com sucesso", "Cadastrado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Bebida já cadastrado!!!", "Já cadastrado", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

                b = null;
            }
            else if (b != null)
            {
                b.Nome = txtNome.Text;
                b.Preco = Convert.ToDouble(txtPreco.Text);

                if (BebidaDAO.AlterarBebida(b))
                {
                    MessageBox.Show("Bebida alterado com sucesso", "Alterado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Erro na alteração!!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
