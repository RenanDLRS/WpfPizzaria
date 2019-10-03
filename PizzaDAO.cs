using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models;

namespace WpfPizzaria.DAL
{
    class PizzaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void GravarPizza(Pizza pizza)
        {
            ctx.Pizzas.Add(pizza);
            ctx.SaveChanges();
        }

    }
}
