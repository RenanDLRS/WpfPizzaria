using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class Venda {
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<ItemVenda> ProdutosVenda { get; set; } //Produtos desta venda
        public DateTime CriadoEm { get; set; }

        public Venda() {
            Cliente = new Cliente();
            Funcionario = new Funcionario();
            CriadoEm = DateTime.Now;
        }
    }
}
