using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http;
using PrototipoKaizen.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrototipoKaizen.Exceptions;
using PrototipoKaizen.DTOs.Aluno;

namespace PrototipoKaizen.Services
{
    public class EnderecoService
    {
        private readonly HttpClient _httpClient;

        public EnderecoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Endereco BuscarEnderecoPorAluno(CreateAlunoDto aluno)
        {
            var response = _httpClient.GetAsync($"https://viacep.com.br/ws/{aluno.Cep}/json").Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new EnderecoNaoEncontradoException("Erro ao buscar endereço: {response.StatusCode}");
            }

            var content = response.Content.ReadAsStringAsync().Result;

            var json = JObject.Parse(content);
            if (json.ContainsKey("erro") && json["erro"]?.Value<bool>() == true)
            {
                throw new EnderecoNaoEncontradoException();
            }

            var endereco = JsonConvert.DeserializeObject<Endereco>(content);
            if (endereco == null)
            {
                throw new EnderecoNaoEncontradoException();
            }

            endereco.Complemento = aluno.Complemento;
            endereco.Numero = aluno.Numero;

            return endereco;
        }

        public Endereco BuscarEnderecoPorCep(string cep)
        {
            var response = _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json").Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new EnderecoNaoEncontradoException("Erro ao buscar endereço: {response.StatusCode}");
            }

            var content = response.Content.ReadAsStringAsync().Result;

            var json = JObject.Parse(content);
            if (json.ContainsKey("erro") && json["erro"]?.Value<bool>() == true)
            {
                throw new EnderecoNaoEncontradoException();
            }

            var endereco = JsonConvert.DeserializeObject<Endereco>(content);
            if (endereco == null)
            {
                throw new EnderecoNaoEncontradoException();
            }

            return endereco;
        }
    }
}