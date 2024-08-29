using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrototipoKaizen.Enums;

namespace PrototipoKaizen.Models
{
    public class Cobranca
    {
        public Guid Id { get; set; }
        public Guid Ativo { get; set; }
        public string? PlanoContratado { get; set; }
        public string? Cpf { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Valor { get; set; }
        public Endereco? EnderecoCobranca { get; set; }
        public FormasPagamento FormaPagamento { get; set; }
    }
}