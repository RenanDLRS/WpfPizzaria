using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models;

namespace WpfPizzaria.DAL
{
    class BebidaDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarBebida(Bebida cliente)
        {
            if (BuscarBebidaPorNome(cliente) == null)
            {
                ctx.Bebidas.Add(cliente);
                ctx.SaveChanges();
                return true;
            }
            return false;           
        }

        public static Bebida BuscarBebidaPorNome(Bebida bebida)
        {
            return ctx.Bebidas.FirstOrDefault(x => x.Nome.Equals(bebida.Nome));
        }

        public static List<Bebida> ListarBebidas()
        {
            return ctx.Bebidas.ToList();
        }
        
        public static Bebida BuscarBebidaPorId(int id)
        {
            return ctx.Bebidas.Find(id);
        }
    }
}
