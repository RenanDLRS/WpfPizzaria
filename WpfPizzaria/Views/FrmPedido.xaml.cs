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

        private List<Pizza> listaPizza = new List<Pizza>();
        Pizza pizza = new Pizza();



        private List<Bebida> listaBebidas = new List<Bebida>();
        Bebida bebida = new Bebida();

        private List<Sabor> listaSabor = new List<Sabor>();
        Sabor sabor = new Sabor();

        private List<ItemVenda> listaItemVenda = new List<ItemVenda>();
        ItemVenda itemVenda = new ItemVenda();


        public FrmPedido()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbSabor.ItemsSource =
            SaborDAO.ListarSabores();
            cbSabor.DisplayMemberPath = "Nome";
            cbSabor.SelectedValuePath = "SaborId";


            cbTamanho.ItemsSource =
            TamanhoDAO.ListarTamanhoes();
            cbTamanho.DisplayMemberPath = "Nome";
            cbTamanho.SelectedValuePath = "TamanhoId";

            cbBebida.ItemsSource =
            BebidaDAO.ListarBebidas();
            cbBebida.DisplayMemberPath = "Nome";
            cbBebida.SelectedValuePath = "BebidaId";
        }
        private void BtnAdcionarBebida_Click(object sender, RoutedEventArgs e)
        {

            int idBebida = Convert.ToInt32(cbBebida.SelectedValue);
            bebida = BebidaDAO.BuscarBebidaPorId(idBebida);

            listaBebidas.Add(bebida);
            dtaBebida.ItemsSource = listaBebidas;
            dtaBebida.Items.Refresh();

        }

        private void btnAddSabor_Click(object sender, RoutedEventArgs e)
        {
            int idTamanho = Convert.ToInt32(cbTamanho.SelectedValue);
            Tamanho t = TamanhoDAO.BuscarTamanhoPorId(idTamanho);

            int idSabor = Convert.ToInt32(cbSabor.SelectedValue);
            sabor = SaborDAO.BuscarSaborPorId(idSabor);

            //Não substiuir tamanho primario da pizza
            if (pizza.Tamanho == null)
            {
                pizza.Tamanho = t;
            }
            listaSabor.Add(sabor);

            dtaSabor.ItemsSource = listaSabor;
            dtaSabor.Items.Refresh();

        }

        private void AddItensPedido_Click(object sender, RoutedEventArgs e)
        {

            //Zerando as lista de sabores e bebidas para reutilizar
            listaBebidas.Clear();
            listaSabor.Clear();
            dtaBebida.ItemsSource = listaBebidas;
            dtaBebida.Items.Refresh();
            dtaSabor.ItemsSource = listaSabor;
            dtaSabor.Items.Refresh();



            //Criando uma pizza e adicionando a l ista de pizzas
            pizza.Sabores = listaSabor;
            listaPizza.Add(pizza);

            //Criando um itemVenda com os dados pizza bebidas e preço
            itemVenda.Pizza = pizza;
            itemVenda.Bebida = bebida;
            itemVenda.Preco = pizza.Tamanho.Preco + bebida.Preco;
            listaItemVenda.Add(itemVenda);

            //Listando a lista itemVendas
            dtaPedido.ItemsSource = listaItemVenda;
            dtaPedido.Items.Refresh();
        }
    }
}
