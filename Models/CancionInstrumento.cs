namespace melodika.Models;
using Newtonsoft.Json;

public class CancionInstrumento
{
    public CancionInstrumento() { }

    [JsonProperty("IdCancionInstrumento")]
    public int IdCancionInstrumento { get; set; }

    [JsonProperty("IdUsuario")]
    public int IdUsuario { get; set; }

    [JsonProperty("IdInstrumento")]
    public int IdInstrumento { get; set; }
}
