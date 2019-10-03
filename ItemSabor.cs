using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models
{
    [Table("ItemSabores")]
    class ItemSabor
    {
        [Key]
        public int IdItemSabor { get; set; }
        public Sabor Sabor { get; set; }
    }
}
