using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    [Table("Pizzas")]
    class Pizza {
        [Key]
        public int Id { get; set; }
        public List<ItemSabor> Sabores { get; set; }
        public Tamanho Tamanho { get; set; } 
        
        public Pizza() {
            Sabores = new List<ItemSabor>();
        }
        public override string ToString()
        {
            return $"Tamanho {Tamanho.Nome} Preço {Tamanho.Preco}";
        }

    }
}
