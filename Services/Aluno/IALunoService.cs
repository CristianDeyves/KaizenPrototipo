using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Services.Aluno
{
    public interface IALunoService
    {
        Task<Aluno> CreateAlunoAsync(CreateAlunoDto novoAluno);
        Task<Aluno> GetAlunoByIdAsync(Guid id);
        Task<Aluno> UpdateEnderecoAsync(Guid id, AtualizarEnderecoDto endereco);
        Task<Aluno> UpdateEmailAsync(Guid id, UpdateEmailDto email);
    }
}