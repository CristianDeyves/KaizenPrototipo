using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototipoKaizen.Context;
using PrototipoKaizen.DTOs.Aluno;
using PrototipoKaizen.DTOs.Endereco;
using PrototipoKaizen.Models;
using PrototipoKaizen.Services;

namespace PrototipoKaizen.Controllers
{
    [ApiController]
    [Route("aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly EnderecoService _enderecoService;
        private readonly KaizenContext _context;

        public AlunoController(EnderecoService enderecoService, KaizenContext context)
        {
            _enderecoService = enderecoService;
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(CreateAlunoDto novoAluno)
        {
            var endereco = _enderecoService.BuscarEnderecoPorAluno(novoAluno);

            if (endereco == null)
            {
                return new NotFoundObjectResult("Endereço não encontrado");
            }
            
            var aluno = new Aluno(novoAluno);

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = aluno.Id }, aluno);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var aluno = _context.Alunos.Find(id);

            if (aluno == null)
            {
                return new NotFoundObjectResult("Aluno não encontrado");
            }

            return Ok(aluno);
        }
        
        [HttpPut("endereco/{id}")]
        public IActionResult UpdateEndereco(Guid id, AtualizarEnderecoDto endereco)
        {
            var aluno = _context.Alunos.Find(id);

            if (aluno == null)
            {
                return new NotFoundObjectResult("Aluno não encontrado");
            }
            
            var enderecoAtualizado = _enderecoService.BuscarEnderecoPorCep(endereco.Cep);

            if (enderecoAtualizado == null)
            {
                return new NotFoundObjectResult("Endereço não encontrado");
            }

            enderecoAtualizado.Complemento = endereco.Complemento;
            enderecoAtualizado.Numero = endereco.Numero;

            aluno.Endereco = enderecoAtualizado;
            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult UpdateEmail(Guid id, UpdateEmailDto email)
        {
            var aluno = _context.Alunos.Find(id);

            if (aluno == null)
            {
                return new NotFoundObjectResult("Aluno não encontrado");
            }

            aluno.Email = email.Email;
            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            return Ok(aluno);
        }
    }
}