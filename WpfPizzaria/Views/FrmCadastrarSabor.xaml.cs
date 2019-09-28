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
        public FrmCadastrarSabor()
        {
            InitializeComponent();
            txtData.Text = DateTime.Now.ToString();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Sabor sabor = new Sabor
            {
                Nome = txtNome.Text,
                CriadoEm = DateTime.Now
            };

            if (SaborDAO.CadastrarSabor(sabor))
            {
                MessageBox.Show("Sabor cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Sabor já cadastrado!!!");
            }           
        }
    }
}
