using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class Pizza {

        public List<ItemSabor> Sabor { get; set; } //Lista 1,2,3 ou 4 sabores
        public Tamanho Tamanho { get; set; } 
        public Pizza() {
        }
    }
}
