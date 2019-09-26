using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models;

namespace WpfPizzaria.DAL
{
    class FuncionarioDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarFuncionario(Funcionario funcionario)
        {
            if (BuscarFuncionarioPorCpf(funcionario) == null)
            {
                ctx.Funcionarios.Add(funcionario);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Funcionario BuscarFuncionarioPorCpf(Funcionario funcionario)
        {
            return ctx.Funcionarios.FirstOrDefault(x => x.Cpf.Equals(funcionario.Cpf));
        }

        public static List<Funcionario> ListarFuncionarios()
        {
            return ctx.Funcionarios.ToList();
        }
    }
}
