using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzaria.Models.Enums;

namespace WpfPizzaria.Models {
    class Funcionario {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public CargoFuncionario cargoFuncionario { get; set; }
        public DateTime CriadoEm { get; set; }

        public Funcionario() {
            CriadoEm = DateTime.Now;
        }

        public override string ToString() {
            return $"Nome: {Nome}, Cpf: {Cpf}, Cargo: {cargoFuncionario}, Data: {CriadoEm}";
        }
    }
}
