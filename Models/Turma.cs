using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Models
{
    public class Turma
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public string? Codigo { get; set; }
        public Guid MentorId { get; set; }
        public Mentor? Mentor { get; set; }
        public Guid CoordenadorID { get; set; }
        public Coordenador? Coordenador { get; set; }
        public List<Aluno>? Alunos { get; set; }
    }
}