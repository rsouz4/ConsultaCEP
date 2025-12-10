using ConsultaCEP.API.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsultaCEP.API;
public class Teste
{
    public string Logradouro{ get; set; }
    public string Complemento { get; set; }
    public string UF{ get; set; }
    public string Estado{ get; set; }


}
public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://viacep.com.br/ws/");
    }

    public async Task<Endereco> BuscaCepAsync(string cep )
    {
        var response = await _httpClient.GetAsync($"{cep}/json/");
        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();
        var endereco = JsonSerializer.Deserialize<Endereco>(json);

        return endereco;
    }


}
