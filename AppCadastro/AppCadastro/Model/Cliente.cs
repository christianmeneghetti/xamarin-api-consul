using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AppCadastro
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Cep { get; set; }
        public decimal? Limite { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Telefone { get; set; }
    }
}
