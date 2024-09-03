using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.DTOs.Aluno
{
    public record CreateAlunoDto
    (
        bool Ativo = true,
        string Cep,
        Pessoa pessoa,
        DateTime DataNascimento,
        ContatoEmergencia ContatoEmergencia,
        Responsavel Responsavel,
        Cobranca Cobranca,
        Mentor Mentor,
        string DiasAulasContratados,
        Guid TurmaId,
        Turma? Turma = null
    );
}