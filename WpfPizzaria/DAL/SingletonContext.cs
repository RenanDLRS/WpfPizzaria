using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models;

namespace WpfPizzaria.DAL
{
    class SingletonContext
    {
        //Atibuto do tipo context
        private static Context ctx;

        //Construtor
        public SingletonContext()
        {
                
        }

        //Método que verefica se o contexto já está instanciado
        //Caso já esteja nao deixa instanciar novamente e retorna o contexto já instanciado
        public static Context GetInstance()
        {
            if (ctx == null)
            {
                ctx = new Context();
            }
            return ctx;
        }
    }
}
