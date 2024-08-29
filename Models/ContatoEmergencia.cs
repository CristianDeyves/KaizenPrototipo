using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Models
{
    public class ContatoEmergencia :Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public Guid IdPessoa { get; set; }
        public string? NomePessoa { get; set; }
    }
}