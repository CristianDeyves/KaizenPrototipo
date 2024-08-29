using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Models
{
    public class DiarioBordo
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public Aluno? Aluno { get; set; }
        public Mentor? Mentor { get; set; }
        public Aviso? Aviso { get; set; }
        public string? ProximaAula { get; set; }
    }
}