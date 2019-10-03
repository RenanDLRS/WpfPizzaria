using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models;

namespace WpfPizzaria.DAL
{
    class ItemSaborDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarItemSabor(int pizzaId, int saborId)
        {
            //ctx.ItemSabores.Add(cliente);
            ctx.SaveChanges();
        }

        public static List<ItemSabor> ListarItemSabors()
        {
            return ctx.ItemSabores.ToList();
        }
        
        public static ItemSabor BuscarItemSaborPorId(int id)
        {
            return ctx.ItemSabores.Find(id);
        }
        public static void DeletarItemSabor(ItemSabor b)
        {
            ctx.ItemSabores.Remove(b);

        }
    }
}
