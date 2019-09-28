using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models;

namespace WpfPizzaria.DAL
{
    class TamanhoDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarTamanho(Tamanho tamanho)
        {
            if (BuscarTamanhoPorNome(tamanho) == null)
            {
                ctx.Tamanhos.Add(tamanho);
                ctx.SaveChanges();
                return true;
            }
            return false;           
        }

        public static Tamanho BuscarTamanhoPorNome(Tamanho Tamanho)
        {
            return ctx.Tamanhos.FirstOrDefault(x => x.Nome.Equals(Tamanho.Nome));
        }

        public static Tamanho BuscarTamanhoPorId(int id)
        {
            return ctx.Tamanhos.Find(id);
        }

        public static List<Tamanho> ListarTamanhoes()
        {
            return ctx.Tamanhos.ToList();
        }
    }
}
