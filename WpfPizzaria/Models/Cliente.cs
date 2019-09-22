using System;

namespace WpfPizzaria.Models {
    class Cliente {

        //Propriedades
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime CriadoEm { get; set; }

        //Construtor
        public Cliente() {
            CriadoEm = DateTime.Now;
        }

        //toString
        public override string ToString() {
            return $"Nome: {Nome}, Cpf: {Cpf}, Telefone{Telefone}, Endereço: {Endereco}, Data de cadastro: {CriadoEm}";
        }
    }
}
