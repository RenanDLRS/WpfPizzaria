using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class Pizza {

        public int Id { get; set; }
        public List<Sabor> Sabores { get; set; } //Lista 1,2,3 ou 4 sabores
        public Tamanho Tamanho { get; set; } 
        
        public Pizza() {
            Sabores = new List<Sabor>();
        }
        public override string ToString()
        {
            return $"Tamanho {Tamanho.Nome} Preço {Tamanho.Preco}";
        }

    }
}
