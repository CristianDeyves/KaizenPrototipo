using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Repositories.Aluno
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly KaizenContext _context;

        public AlunoRepository(KaizenContext context)
        {
            _context = context;
        }

        public async Task<Aluno> GetByIdAsync(Guid id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task<List<Aluno>> GetAllAsync()
        {
            return await _context.Alunos.ToListAsync();
        }

        public async Task AddAsync(Aluno aluno)
        {
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var aluno = await GetByIdAsync(id);
            if (aluno != null)
            {
                _context.Alunos.Remove(aluno);
                await _context.SaveChangesAsync();
            }
        }
    }
}