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
        Funcionario f = null;

        //1=gerente 2=cozinheiro 3=atendente
        public int opc = 0;

        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
            txtData.Text = DateTime.Now.ToString();
        }

        public FrmCadastrarFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            btnCadastrar.Content = "Alterar";

            txtNome.Text = funcionario.Nome;
            txtData.Text = funcionario.CriadoEm.ToString();
            txtCpf.Text = funcionario.Cpf.ToString();
            
            if (funcionario.cargoFuncionario == CargoFuncionario.Gerente)
            {
                opc1.IsChecked = true;
            }
            else if (funcionario.cargoFuncionario == CargoFuncionario.Cozinheiro)
            {
                opc2.IsChecked = true;
            }
            else if (funcionario.cargoFuncionario == CargoFuncionario.Atendente)
            {
                opc3.IsChecked = true;
            }

            f = funcionario;

            txtData.Text = DateTime.Now.ToString();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            if (f == null)
            {
                f = new Funcionario();

                f.Nome = txtNome.Text;
                f.Cpf = txtCpf.Text;
                f.CriadoEm = DateTime.Now;

                if (opc1.IsChecked == true)
                {
                    f.cargoFuncionario = CargoFuncionario.Gerente;
                }
                else if (opc2.IsChecked == true)
                {
                    f.cargoFuncionario = CargoFuncionario.Cozinheiro;
                }
                else if (opc3.IsChecked == true)
                {
                    f.cargoFuncionario = CargoFuncionario.Atendente;
                }

                if (FuncionarioDAO.CadastrarFuncionario(f))
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso", "Cadastrado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Funcionario já cadastrado!!!", "Já cadastrado", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

                f = null;
            }
            else if (f != null)
            {
                f.Nome = txtNome.Text;
                f.Cpf = txtCpf.Text;

                if (opc1.IsChecked == true)
                {
                    f.cargoFuncionario = CargoFuncionario.Gerente;
                }
                else if (opc2.IsChecked == true)
                {
                    f.cargoFuncionario = CargoFuncionario.Cozinheiro;
                }
                else if (opc3.IsChecked == true)
                {
                    f.cargoFuncionario = CargoFuncionario.Atendente;
                }

                if (FuncionarioDAO.AlterarFuncionario(f))
                {
                    MessageBox.Show("Funcionario alterado com sucesso", "Alterado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Erro na alteração!!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
