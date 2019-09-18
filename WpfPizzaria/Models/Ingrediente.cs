using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class Ingrediente {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Ingrediente() {

        }
        public override string ToString() {
            return $"Nome ingrediente: {Nome}, Quantidade: {Quantidade}";
        }
    }
}
