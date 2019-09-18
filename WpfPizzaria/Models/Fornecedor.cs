using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPizzaria.Models {
    class Fornecedor {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime CriadoEm { get; set; }

        public Fornecedor() {
            CriadoEm = DateTime.Now;
        }

        public override string ToString() {
            return $"Nome: {Nome}, Cpf: {Cpf}, Endereço: {Endereco}";
        }
    }
}
