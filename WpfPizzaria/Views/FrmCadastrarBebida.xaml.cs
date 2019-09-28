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
        public FrmCadastrarBebida()
        {
            InitializeComponent();
            txtData.Text = DateTime.Now.ToString();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Bebida bebida = new Bebida
            {
                Nome = txtNome.Text,
                CriadoEm = DateTime.Now
            };

            if (BebidaDAO.CadastrarBebida(bebida))
            {
                MessageBox.Show("Bebida cadastrada com sucesso");
            }
            else
            {
                MessageBox.Show("Bebida já cadastrada!!!");
            }           
        }
    }
}
