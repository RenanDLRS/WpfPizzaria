using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models
{
    class Context : DbContext
    {
        //Constutror defininco nome do banco de dados
        public Context() : base("DbPizzaria") { }

        //propriedades especificando quais entidades se tornará tabelas
        public DbSet<Cliente> Clientes { get; set; }
    }
}
