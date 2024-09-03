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
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAlunoDto novoAluno)
        {
            try
            {
                var aluno = await _alunoService.CreateAlunoAsync(novoAluno);
                return CreatedAtAction(nameof(GetById), new { id = aluno.Id }, aluno);
            }
            catch (EnderecoNaoEncontradoException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var aluno = await _alunoService.GetAlunoByIdAsync(id);
                return Ok(aluno);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("endereco/{id}")]
        public async Task<IActionResult> UpdateEndereco(Guid id, AtualizarEnderecoDto endereco)
        {
            try
            {
                var aluno = await _alunoService.UpdateEnderecoAsync(id, endereco);
                return Ok(aluno);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (EnderecoNaoEncontradoException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("email/{id}")]
        public async Task<IActionResult> UpdateEmail(Guid id, UpdateEmailDto email)
        {
            try
            {
                var aluno = await _alunoService.UpdateEmailAsync(id, email);
                return Ok(aluno);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
