using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Models
{
    public class Mentor : Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public ContatoEmergencia? ContatoEmergencia { get; set; }
        public InformacoesPagamento? InformacoesPagamento { get; set; }
        public List<Turma>? Turmas { get; set; }
        public List<Aluno>? Alunos { get; set; }
        public List<Aula>? Aulas { get; set; }
        public List<DiarioBordo>? DiariosBordo { get; set; }
        public List<Formacoes>? Formacoes { get; set; }
        public string? TipoMentor { get; set; }
    }
}