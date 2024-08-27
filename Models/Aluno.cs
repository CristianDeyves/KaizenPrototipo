using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using PrototipoKaizen.DTOs.Aluno;

namespace PrototipoKaizen.Models
{
    public class Aluno : Pessoa
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public ContatoEmergencia ContatoEmergencia { get; set; }
        public Responsavel Responsavel { get; set; }
        public Cobranca Cobranca { get; set; }
        public Mentor Mentor { get; set; }
        public Guid TurmaId { get; set; }
        public Turma Turma { get; set; }
        public List<Aula> Aulas { get; set; }
        public List<DiarioBordo> DiariosBordo { get; set; }
        public string DiasAulasContratados { get; set; }

        public Aluno(CreateAlunoDto novoAluno)
        {
            Id = Guid.NewGuid();
            Ativo = novoAluno.Ativo;
            Nome = novoAluno.pessoa.Nome;
            Cpf = novoAluno.pessoa.Cpf;
            Rg = novoAluno.pessoa.Rg;
            DataNascimento = novoAluno.DataNascimento;
            ContatoEmergencia = novoAluno.ContatoEmergencia;
            Responsavel = novoAluno.Responsavel;
            Cobranca = novoAluno.Cobranca;
            Mentor = novoAluno.Mentor;
            TurmaId = novoAluno.TurmaId;
            Turma = novoAluno.Turma;
            DiasAulasContratados = novoAluno.DiasAulasContratados;
        }
    }
}
