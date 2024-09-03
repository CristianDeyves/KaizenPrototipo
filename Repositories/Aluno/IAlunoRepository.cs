using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Repositories.Aluno
{
    public interface IAlunoRepository
    {
        Task<Aluno> GetByIdAsync(Guid id);
        Task<List<Aluno>> GetAllAsync();
        Task AddAsync(Aluno aluno);
        Task UpdateAsync(Aluno aluno);
        Task DeleteAsync(Guid id);
    }
}