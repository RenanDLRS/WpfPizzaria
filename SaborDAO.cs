using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models;

namespace WpfPizzaria.DAL
{
    class SaborDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarSabor(Sabor cliente)
        {
            if (BuscarSaborPorNome(cliente) == null)
            {
                ctx.Sabores.Add(cliente);
                ctx.SaveChanges();
                return true;
            }
            return false;           
        }

        public static bool DeletarSabor(Sabor Sabor)
        {
            Sabor s = BuscarSaborPorId(Sabor.SaborId);
            if (s != null)
            {
                ctx.Sabores.Remove(s);
                ctx.SaveChanges();
                return true;
            }

            return false;
        }

        public static bool AlterarSabor(Sabor Sabor)
        {
            Sabor s = BuscarSaborPorId(Sabor.SaborId);
            if (s != null)
            {
                ctx.Entry(s).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }

            return false;
        }

        public static Sabor BuscarSaborPorNome(Sabor sabor)
        {
            return ctx.Sabores.FirstOrDefault(x => x.Nome.Equals(sabor.Nome));
        }

        public static List<Sabor> ListarSabores()
        {
            return ctx.Sabores.ToList();
        }

        public static Sabor BuscarSaborPorId(int id)
        {
            return ctx.Sabores.Find(id);
        }
    }
}
