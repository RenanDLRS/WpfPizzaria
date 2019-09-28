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
        public FrmCadastrarTamanho()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Tamanho Tamanho = new Tamanho
            {
                Nome = txtNome.Text,
                Preco = Convert.ToDouble(txtPreco.Text)
            };

            if (TamanhoDAO.CadastrarTamanho(Tamanho))
            {
                MessageBox.Show("Tamanho cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Tamanho já cadastrado!!!");
            }           
        }
    }
}
