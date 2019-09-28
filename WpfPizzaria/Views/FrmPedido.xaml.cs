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
        //Lista objeto dinamico para sobores da pizza
        private List<Sabor> sabores = new List<Sabor>();
        private List<Pizza> pizza = new List<Pizza>();

        //Lista objeto dinamico para bebidas
        private List<dynamic> bebidas = new List<dynamic>();

        private List<dynamic> itemVenda = new List<dynamic>();        

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

        //Botão para adicionar sabores
        private void btnAddSabor_Click(object sender, RoutedEventArgs e)
        {
            int idTamanho = Convert.ToInt32(cbTamanho.SelectedValue);
            Tamanho t = TamanhoDAO.BuscarTamanhoPorId(idTamanho);

            int idSabor = Convert.ToInt32(cbSabor.SelectedValue);
            Sabor s = SaborDAO.BuscarSaborPorId(idSabor);
                       
            sabores.Add(s);
            dtaPizza.ItemsSource = sabores;
            dtaPizza.Items.Refresh();
           
        }

        //Botão para adicionar bebidas
        private void BtnAdcionarBebida_Click(object sender, RoutedEventArgs e)
        {

            int idBebida = Convert.ToInt32(cbBebida.SelectedValue);
            Bebida b = BebidaDAO.BuscarBebidaPorId(idBebida);

            bebidas.Add(b);
            dtaBebida.ItemsSource = bebidas;
            dtaBebida.Items.Refresh();

        }

        private void BtnAdicionarPizzaPedido_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
