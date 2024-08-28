using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Models
{
    public class InformacoesPagamento
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public string? CnpjCpf { get; set; }
        public string? Nome { get; set; }
        public Endereco? Endereco { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}