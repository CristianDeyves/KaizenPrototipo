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
using Microsoft.Extensions.Http;

namespace PrototipoKaizen.Services
{
    public class EnderecoService
    {
        public const string ViaCepUrl = nameof(EnderecoService);
        private readonly HttpClient _httpClient;

        public EnderecoService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient(ViaCepUrl);
        }

        public async Task<Endereco> BuscarEnderecoPorAluno(CreateAlunoDto aluno)
        {
            var response = await _httpClient.GetAsync($"/{aluno.Cep}/json");

            if (!response.IsSuccessStatusCode)
            {
                throw new EnderecoNaoEncontradoException("Erro ao buscar endereço: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();

            var json = JObject.Parse(content);
            if (json.ContainsKey("erro") && json["erro"]?.Value<bool>())
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

        public async Task<Endereco> BuscarEnderecoPorCep(string cep)
        {
            var response = await _httpClient.GetAsync($"/{cep}/json");

            if (!response.IsSuccessStatusCode)
            {
                throw new EnderecoNaoEncontradoException("Erro ao buscar endereço: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();

            var json = JObject.Parse(content);
            if (json.ContainsKey("erro") && json["erro"]?.Value<bool>())
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