using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class ItemSabor {
        public Sabor Sabor { get; set; }
        public int Quantidade { get; set; } //Identificar quantidade daquele sabor
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

        public ItemSabor() {
            Sabor = new Sabor();
            CriadoEm = DateTime.Now;
        }
    }
}
