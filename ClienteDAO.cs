using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models;

namespace WpfPizzaria.DAL
{
    class ClienteDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarCliente(Cliente cliente)
        {
            if (BuncasClientePorCpf(cliente) == null)
            {
                ctx.Clientes.Add(cliente);
                ctx.SaveChanges();
                return true;
            }
            return false;           
        }

        public static bool DeletarCliente(Cliente Cliente)
        {
            Cliente c = BuscarClientePorId(Cliente.ClienteId);
            if (c != null)
            {
                ctx.Clientes.Remove(c);
                ctx.SaveChanges();
                return true;
            }

            return false;
        }

        public static bool AlterarCliente(Cliente Cliente)
        {
            Cliente c = BuscarClientePorId(Cliente.ClienteId);
            if (c != null)
            {
                ctx.Entry(c).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }

            return false;
        }

        public static Cliente BuscarClientePorId(int id)
        {
            return ctx.Clientes.Find(id);
        }

        public static Cliente BuncasClientePorCpf(Cliente cliente)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Cpf.Equals(cliente.Cpf));
        }

        public static List<Cliente> ListarClientes()
        {
            return ctx.Clientes.ToList();
        }
    }
}
