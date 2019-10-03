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
    /// Interaction logic for FrmCadastrarTamanho.xaml
    /// </summary>
    public partial class FrmCadastrarTamanho : Window
    {
        Tamanho t = null;

        public FrmCadastrarTamanho()
        {
            InitializeComponent();
        }


        public FrmCadastrarTamanho(Tamanho tamanho)
        {
            InitializeComponent();
            btnCadastrar.Content = "Alterar";

            txtNome.Text = tamanho.Nome;
            txtPreco.Text = tamanho.Preco.ToString();

            t = tamanho;
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            if (t == null)
            {
                t = new Tamanho();
                t.Nome = txtNome.Text;
                t.Preco = Convert.ToDouble(txtPreco.Text);

                if (TamanhoDAO.CadastrarTamanho(t))
                {
                    MessageBox.Show("Tamanho cadastrado com sucesso", "Cadastrado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Tamanho já cadastrado!!!", "Já cadastrado", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

                t = null;
            }
            else if (t != null)
            {
                t.Nome = txtNome.Text;
                t.Preco = Convert.ToDouble(txtPreco.Text);

                if (TamanhoDAO.AlterarTamanho(t))
                {
                    MessageBox.Show("Tamanho alterado com sucesso", "Alterado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Erro na alteração!!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
