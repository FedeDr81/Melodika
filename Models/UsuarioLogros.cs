namespace melodika.Models;
using Newtonsoft.Json;

public class UsuarioLogros
{
    public UsuarioLogros() { }

    [JsonProperty("IdUsuarioLogros")]
    public int IdUsuarioLogros { get; set; }

    [JsonProperty("IdUsuario")]
    public int IdUsuario { get; set; }

    [JsonProperty("IdLogro")]
    public int IdLogro { get; set; }

    [JsonProperty("FechaObtenido")]
    public DateTime FechaObtenido { get; set; }
}
