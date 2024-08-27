using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.DTOs.Aluno
{
    public record CreateAlunoDto
    (
        bool Ativo = true,
        Pessoa pessoa,
        DateTime DataNascimento,
        ContatoEmergencia ContatoEmergencia,
        Responsavel Responsavel,
        Cobranca Cobranca,
        Mentor Mentor,
        Guid TurmaId,
        Turma Turma,
        string DiasAulasContratados
    );
}