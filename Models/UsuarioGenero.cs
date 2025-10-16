namespace melodika.Models;
using Newtonsoft.Json;

public class UsuarioGenero
{
    public UsuarioGenero() { }

    [JsonProperty("IdUsuarioGenero")]
    public int IdUsuarioGenero { get; set; }

    [JsonProperty("IdUsuario")]
    public int IdUsuario { get; set; }

    [JsonProperty("IdGenero")]
    public int IdGenero { get; set; }
}
