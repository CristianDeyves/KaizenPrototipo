using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoKaizen.Exceptions
{
    public class EnderecoNaoEncontradoException : Exception
    {
        public EnderecoNaoEncontradoException() : base("Endereço não encontrado, CEP não encontrado")
        {
        }

        public EnderecoNaoEncontradoException(string message) : base(message)
        {
        }

        public EnderecoNaoEncontradoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}