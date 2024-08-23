using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.DTOs.Aluno
{
    public record CreateAlunoDto
    (
        string Nome,
        string Email,
        string Cpf,
        string DataNascimento,
        string Telefone,
        string Cep,
        string Complemento,
        string Numero
    );
}