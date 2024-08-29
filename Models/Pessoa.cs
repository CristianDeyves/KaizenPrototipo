using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Models
{
    public class Pessoa
    {
        // Informações pessoais
        public string? PrimeiroNome { get; set; }
        public string? SegundoNome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Cpf { get; set; }
        public string? Rg { get; set; }
        // Informações de contato
        public Endereco? Endereco { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
}