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
    /// Interaction logic for Pedido.xaml
    /// </summary>
    public partial class FrmPedido : Window
    {
        private List<Bebida> listaBebidas = new List<Bebida>();
        private List<Pizza> listaPizza = new List<Pizza>();
        private List<Sabor> listaSabor = new List<Sabor>();
        private List<ItemVenda> listaItemVenda = new List<ItemVenda>();
        private List<Venda> listaVenda = new List<Venda>();

        private List<dynamic> ListaProdutos = new List<dynamic>();
        private List<dynamic> listaViewVenda = new List<dynamic>();        

        Pizza pizza;        
        Sabor sabor;
        ItemVenda itemVenda;        
        Bebida bebida;        
        Funcionario funcionario;
        Cliente cliente;
        Venda venda;        

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbSabor.ItemsSource = SaborDAO.ListarSabores();
            cbSabor.DisplayMemberPath = "Nome";
            cbSabor.SelectedValuePath = "SaborId";

            cbTamanho.ItemsSource = TamanhoDAO.ListarTamanhoes();
            cbTamanho.DisplayMemberPath = "Nome";
            cbTamanho.SelectedValuePath = "TamanhoId";

            cbBebida.ItemsSource = BebidaDAO.ListarBebidas();
            cbBebida.DisplayMemberPath = "Nome";
            cbBebida.SelectedValuePath = "BebidaId";
        }

        private void BtnAdcionarBebida_Click(object sender, RoutedEventArgs e)
        {
            bebida = new Bebida();
            int idBebida = Convert.ToInt32(cbBebida.SelectedValue);
            bebida = BebidaDAO.BuscarBebidaPorId(idBebida);

            listaBebidas.Add(bebida);
            dtaBebida.ItemsSource = listaBebidas;
            dtaBebida.Items.Refresh();
        }


        private void btnAddSabor_Click(object sender, RoutedEventArgs e)
        {
            pizza = new Pizza();            
            int idTamanho = Convert.ToInt32(cbTamanho.SelectedValue);
            Tamanho t = TamanhoDAO.BuscarTamanhoPorId(idTamanho);
            pizza.Tamanho = t;
            listaPizza.Add(pizza);

            sabor = new Sabor();
            int idSabor = Convert.ToInt32(cbSabor.SelectedValue);
            sabor = SaborDAO.BuscarSaborPorId(idSabor);

            listaSabor.Add(sabor);
            dtaSabor.ItemsSource = listaSabor;
            dtaSabor.Items.Refresh();
        }

        private void AddItensPedido_Click(object sender, RoutedEventArgs e)
        {

            itemVenda = new ItemVenda();
            itemVenda.Pizzas = listaPizza;
            itemVenda.Bebidas = listaBebidas;
            double precoBebida = 0, precoPizza = 0;
            foreach (var pizza in listaPizza)
            {
                precoPizza += pizza.Tamanho.Preco;
            }
            foreach (var bebida in listaBebidas)
            {
                precoBebida += bebida.Preco;
            }
            itemVenda.Preco = precoBebida + precoPizza;
            listaItemVenda.Add(itemVenda);

            dynamic d = new
            {
                Tamanho = pizza.Tamanho.Nome,
                PreçoPizza = pizza.Tamanho.Preco,
                SaboresQqtd = pizza.Tamanho.QtdSabores,
                Bebida = bebida.Nome,
                PreçoBebida = bebida.Preco,
                Preço = pizza.Tamanho.Preco + bebida.Preco
            };

            ListaProdutos.Add(d);
            dtaItensVenda.ItemsSource = ListaProdutos;
            dtaItensVenda.Items.Refresh();            
        }

        private void btnFecharPedido_Click(object sender, RoutedEventArgs e)
        {
            funcionario = new Funcionario();
            funcionario.Cpf = txtCpfVendedor.Text;
            funcionario = FuncionarioDAO.BuscarFuncionarioPorCpf(funcionario);

            cliente = new Cliente();
            cliente.Cpf = txtCpfCliente.Text;
            cliente = ClienteDAO.BuncasClientePorCpf(cliente);

            if (funcionario != null)
            {
                if (cliente != null)
                {
                    venda = new Venda();
                    venda.Cliente = cliente;
                    venda.Funcionario = funcionario;
                    venda.ProdutosVenda = listaItemVenda;
                    foreach (var item in listaItemVenda)
                    {
                        venda.Preco += itemVenda.Preco;
                    }
                    
     
                    listaVenda.Add(venda);

                    dynamic d = new
                    {
                        Vendedor = funcionario.Nome,
                        Cliente = cliente.Nome,
                        Preco = venda.Preco,
                        Data = venda.CriadoEm
                    };
                    listaViewVenda.Add(d);

                    dtaVenda.ItemsSource = listaViewVenda;
                    dtaVenda.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado!!!");
                }
            }
            else
            {
                MessageBox.Show("Funcionario não cadastrado!!!");
            }
        }
    }
}
