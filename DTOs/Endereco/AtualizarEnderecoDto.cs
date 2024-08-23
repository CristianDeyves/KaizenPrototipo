using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.DTOs.Endereco
{
    public record AtualizarEnderecoDto
    (
        string Cep,
        string Numero,
        string Complemento
    );
}