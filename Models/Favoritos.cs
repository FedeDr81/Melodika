namespace melodika.Models;
using Newtonsoft.Json;

public class Favoritos
{
    public Favoritos() { }

    [JsonProperty("IdFavoritos")]
    public int IdFavoritos { get; set; }

    [JsonProperty("IdUsuario")]
    public int IdUsuario { get; set; }

    [JsonProperty("IdCancion")]
    public int IdCancion { get; set; }
}
