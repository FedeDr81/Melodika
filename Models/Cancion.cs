namespace melodika.Models;
using Newtonsoft.Json;

public class Cancion
{
    public Cancion() { }

    [JsonProperty("IdCancion")]
    public int IdCancion { get; set; }

    [JsonProperty("Titulo")]
    public string Titulo { get; set; }

    [JsonProperty("Autor")]
    public string Autor { get; set; }

    [JsonProperty("Portada")]
    public string Portada { get; set; }

    [JsonProperty("Dificultad")]
    public string Dificultad { get; set; }

    [JsonProperty("IdGenero")]
    public int IdGenero { get; set; }
}
