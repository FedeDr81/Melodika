namespace melodika.Models;
using Newtonsoft.Json;

public class Instrumento
{
    public Instrumento() { }

    [JsonProperty("IdInstrumento")]
    public int IdInstrumento { get; set; }

    [JsonProperty("NombreInstrumento")]
    public string NombreInstrumento { get; set; }

    [JsonProperty("DescripcionInstrumento")]
    public string DescripcionInstrumento { get; set; }

    [JsonProperty("ProfundidadAprendizaje")]
    public string ProfundidadAprendizaje { get; set; }

    [JsonProperty("TipoInstrumento")]
    public string TipoInstrumento { get; set; }
}
