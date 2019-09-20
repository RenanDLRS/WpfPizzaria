using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class Sabor {
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }

        public Sabor() {
            CriadoEm = DateTime.Now;
        }

        public override string ToString() {
            return $"Nome do sabor: {Nome}, Criado em: {CriadoEm}";
        }
    }
}
