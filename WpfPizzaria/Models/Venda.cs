using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models.Enums;

namespace WpfPizzaria.Models {
    class Venda {
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<ItemVenda> ProdutosVenda { get; set; } //Produtos desta venda
        public StatusPedido statusPedido { get; set; }
        public DateTime CriadoEm { get; set; }

        public Venda() {
            Cliente = new Cliente();
            Funcionario = new Funcionario();
            CriadoEm = DateTime.Now;
            statusPedido = StatusPedido.PagamentoPendente;
        }
    }
}
