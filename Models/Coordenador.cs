using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Models
{
    public class Coordenador : Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public ContatoEmergencia? ContatoEmergencia { get; set; }
        public List<Mentor>? Mentores { get; set; }
        public List<Turma>? Turmas { get; set; }
        public List<Aula>? Aulas { get; set; }
        public List<Formacoes>? FormacoesMinistradas { get; set; }
        public List<Aviso>? Avisos { get; set; }
    }
}