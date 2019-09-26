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
using WpfPizzaria.Models.Enums;

namespace WpfPizzaria.Views
{
    /// <summary>
    /// Interaction logic for FrmCadastrarFuncionario.xaml
    /// </summary>
    public partial class FrmCadastrarFuncionario : Window
    {
        //1=gerente 2=cozinheiro 3=atendente
        public int opc = 0;

        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
            txtData.Text = DateTime.Now.ToString();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.CriadoEm = DateTime.Now;

            if (opc1.IsChecked == true)
            {
                funcionario.cargoFuncionario = CargoFuncionario.Gerente; 
            }else if (opc2.IsChecked == true)
            {
                funcionario.cargoFuncionario = CargoFuncionario.Cozinheiro;
            }
            else if (opc3.IsChecked == true)
            {
                funcionario.cargoFuncionario = CargoFuncionario.Atendente;
            }

            if (FuncionarioDAO.CadastrarFuncionario(funcionario))
            {
                MessageBox.Show("Funcionario cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Funcionario já cadastrado!!!");
            }


        }
    }
}
