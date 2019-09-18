using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class Bebida {

        public int BebidaId { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }

        public Bebida() {
            CriadoEm = DateTime.Now;
        }

        public override string ToString() {
            return $"Nome da bebida: {Nome}";
        }
    }
}
