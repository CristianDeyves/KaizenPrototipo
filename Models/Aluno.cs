using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using PrototipoKaizen.DTOs.Aluno;

namespace PrototipoKaizen.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Aluno(CreateAlunoDto novoAluno, Endereco endereco)
        {
            Id = Guid.NewGuid();
            Nome = novoAluno.Nome;
            Email = novoAluno.Email;

            DataNascimento = DateTime.ParseExact(
                novoAluno.DataNascimento, "dd/MM/yyyy", CultureInfo.InvariantCulture
            );

            Telefone = novoAluno.Telefone;
            Endereco = endereco;
        }
    }
}
