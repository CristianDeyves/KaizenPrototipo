using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrototipoKaizen.DTOs.Aluno;
using PrototipoKaizen.DTOs.Email;
using PrototipoKaizen.DTOs.Endereco;
using PrototipoKaizen.Repositories;
using PrototipoKaizen.Context;
using PrototipoKaizen.Models;

namespace PrototipoKaizen.Services.Aluno
{
    public class AlunoService : IALunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly EnderecoService _enderecoService;

        public AlunoService(IAlunoRepository alunoRepository, EnderecoService enderecoService)
        {
            _alunoRepository = alunoRepository;
            _enderecoService = enderecoService;
        }

        public async Task<Aluno> CreateAlunoAsync(CreateAlunoDto novoAluno)
        {
            var endereco = await _enderecoService.BuscarEnderecoPorAluno(novoAluno);

            if (endereco == null)
            {
                throw new EnderecoNaoEncontradoException("Endereço não encontrado");
            }

            var aluno = new Aluno(novoAluno);

            await _alunoRepository.AddAsync(aluno);
            return aluno;
        }

        public async Task<Aluno> GetAlunoByIdAsync(Guid id)
        {
            var aluno = await _alunoRepository.GetByIdAsync(id);

            if (aluno == null)
            {
                throw new KeyNotFoundException("Aluno não encontrado");
            }

            return aluno;
        }

        public async Task<Aluno> UpdateEnderecoAsync(Guid id, AtualizarEnderecoDto enderecoDto)
        {
            var aluno = await _alunoRepository.GetByIdAsync(id);

            if (aluno == null)
            {
                throw new KeyNotFoundException("Aluno não encontrado");
            }

            var enderecoAtualizado = await _enderecoService.BuscarEnderecoPorCep(enderecoDto.Cep);

            if (enderecoAtualizado == null)
            {
                throw new EnderecoNaoEncontradoException("Endereço não encontrado");
            }

            enderecoAtualizado.Complemento = enderecoDto.Complemento;
            enderecoAtualizado.Numero = enderecoDto.Numero;

            aluno.Endereco = enderecoAtualizado;
            await _alunoRepository.UpdateAsync(aluno);

            return aluno;
        }

        public async Task<Aluno> UpdateEmailAsync(Guid id, UpdateEmailDto emailDto)
        {
            var aluno = await _alunoRepository.GetByIdAsync(id);

            if (aluno == null)
            {
                throw new KeyNotFoundException("Aluno não encontrado");
            }

            aluno.Email = emailDto.Email;
            await _alunoRepository.UpdateAsync(aluno);

            return aluno;
        }
    }
}