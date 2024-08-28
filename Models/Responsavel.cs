using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Models
{
    public class Responsavel : Pessoa
    {
        public Gui Id { get; set; }
        public bool Ativo { get; set; }
        public Guid ResponsavelPorTalPessoa { get; set; }
        public string NomePessoa { get; set; }
    }
}