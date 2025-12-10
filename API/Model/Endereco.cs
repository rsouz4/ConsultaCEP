using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsultaCEP.API.Model;

public class Endereco
{
    [JsonPropertyName("logradouro")]
    public string Logradouro { get; set; }
    [JsonPropertyName("complemento")]
    public string Complemento { get; set; }
    [JsonPropertyName("uf")]
    public string UF { get; set; }
    [JsonPropertyName("estado")]
    public string Estado { get; set; }
    [JsonPropertyName("localidade")]
    public string Localidade { get; set; }
    [JsonPropertyName("numero")]
    public string Numero { get; set; }


}
