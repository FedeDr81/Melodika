namespace melodika.Models;
using Newtonsoft.Json;

public class UsuarioInstrumento
{
    public UsuarioInstrumento() { }

    [JsonProperty("IdUsuarioInstrumento")]
    public int IdUsuarioInstrumento { get; set; }

    [JsonProperty("IdUsuario")]
    public int IdUsuario { get; set; }

    [JsonProperty("IdInstrumento")]
    public int IdInstrumento { get; set; }
}
