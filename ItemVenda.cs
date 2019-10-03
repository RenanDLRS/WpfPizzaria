using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class ItemVenda {
        public int Id { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<Bebida> Bebidas { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

        public ItemVenda() {
            Pizzas = new List<Pizza>();
            Bebidas = new List<Bebida>();
            CriadoEm = DateTime.Now;
        }
    }
}
