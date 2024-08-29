using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrototipoKaizen.Enums;

namespace PrototipoKaizen.Models
{
    public class Aula
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime Marcada { get; set; }
        public DateTime Remarcacao { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public TimeSpan HoraInicioRemarcacao { get; set; }
        public TimeSpan HoraFimRemarcacao { get; set; }
        public TipoAula TipoAula { get; set; }
        public Coordenador? Coordenador { get; set; }
        public Mentor? Mentor { get; set; }
        public List<Aluno>? Alunos { get; set; }
        public List<bool>? Presenca { get; set; }
    }
}