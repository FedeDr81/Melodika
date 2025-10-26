namespace melodika.Models;
using Newtonsoft.Json;

public class Logros
{
    public Logros() { }

    [JsonProperty("IdLogros")]
    public int IdLogros { get; set; }

    [JsonProperty("NombreLogro")]
    public string NombreLogro { get; set; }

    [JsonProperty("DescripcionLogro")]
    public string DescripcionLogro { get; set; }

    [JsonProperty("TipoLogro")]
    public string TipoLogro { get; set; }

    [JsonProperty("Progreso")]
    public double Progreso { get; set; }
}
