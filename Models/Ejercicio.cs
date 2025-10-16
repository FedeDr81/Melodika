namespace melodika.Models;
using Newtonsoft.Json;

public class Ejercicio
{
    public Ejercicio() { }

    [JsonProperty("IdEjercicio")]
    public int IdEjercicio { get; set; }

    [JsonProperty("DescripcionEjercicio")]
    public string DescripcionEjercicio { get; set; }

    [JsonProperty("TipoEjercicio")]
    public string TipoEjercicio { get; set; }

    [JsonProperty("Dificultad")]
    public string Dificultad { get; set; }

    [JsonProperty("IdCurso")]
    public int IdCurso { get; set; }
}
