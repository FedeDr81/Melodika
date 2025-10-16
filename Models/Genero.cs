namespace melodika.Models;
using Newtonsoft.Json;

public class Genero
{
    public Genero() { }

    [JsonProperty("IdGenero")]
    public int IdGenero { get; set; }

    [JsonProperty("NombreGenero")]
    public string NombreGenero { get; set; }

    [JsonProperty("DescripcionGenero")]
    public string DescripcionGenero { get; set; }
}
