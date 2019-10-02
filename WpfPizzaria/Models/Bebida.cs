using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    [Table("Bebidas")]
    class Bebida {
        [Key]
        public int BebidaId { get; set; }
        public string Nome { get; set; }
        public Double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

        public Bebida() {
            CriadoEm = DateTime.Now;
        }

        public override string ToString() {
            return $"ID {BebidaId} Bebida {Nome} Preço {Preco}";
        }
    }
}
