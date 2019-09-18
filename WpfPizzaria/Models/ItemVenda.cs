using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class ItemVenda {
        public Pizza Pizza { get; set; }
        public Bebida Bebida { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

        public ItemVenda() {
            Pizza = new Pizza();
            Bebida = new Bebida();
            CriadoEm = DateTime.Now;
        }
    }
}
