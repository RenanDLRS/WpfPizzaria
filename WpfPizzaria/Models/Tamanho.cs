using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {

    [Table("Tamanhos")]
    public class Tamanho {
        [Key]
        public int TamanhoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QtdSabores { get; set; }

    }
}
