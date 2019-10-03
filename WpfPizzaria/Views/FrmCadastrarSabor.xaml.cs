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
    /// Interaction logic for FrmCadastrarSabor.xaml
    /// </summary>
    public partial class FrmCadastrarSabor : Window
    {
        Sabor s = null;

        public FrmCadastrarSabor()
        {
            InitializeComponent();
            txtData.Text = DateTime.Now.ToString();
        }

        public FrmCadastrarSabor(Sabor sabor)
        {
            InitializeComponent();
            btnCadastrar.Content = "Alterar";

            txtNome.Text = sabor.Nome;
            txtData.Text = sabor.CriadoEm.ToString();

            s = sabor;
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (s == null)
            {
                s = new Sabor();

                s.Nome = txtNome.Text;
                s.CriadoEm = DateTime.Now;

                if (SaborDAO.CadastrarSabor(s))
                {
                    MessageBox.Show("Sabor cadastrado com sucesso", "Cadastrado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Sabor já cadastrado!!!", "Já cadastrado", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

                s = null;
            }
            else if (s != null)
            {
                s.Nome = txtNome.Text;

                if (SaborDAO.AlterarSabor(s))
                {
                    MessageBox.Show("Sabor alterado com sucesso", "Alterado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Erro na alteração!!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
