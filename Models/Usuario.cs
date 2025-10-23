namespace melodika.Models;
using Newtonsoft.Json;

public class Usuario
{
    public Usuario() { }

    [JsonProperty("IdUsuario")]
    public int IdUsuario { get; set; }

    [JsonProperty("Nombre")]
    public string Nombre { get; set; }

    [JsonProperty("Username")]
    public string Username { get; set; }

    [JsonProperty("CorreoElectronico")]
    public string CorreoElectronico { get; set; }

    [JsonProperty("Contraseña")]
    public string Contraseña { get; set; }

    [JsonProperty("FechaNacimiento")]
    public DateTime FechaNacimiento { get; set; }

    [JsonProperty("Rol")]
    public string Rol { get; set; }

    [JsonProperty("FechaRegistro")]
    public DateTime FechaRegistro { get; set; }

    [JsonProperty("FotoPerfil")]
    public string FotoPerfil { get; set; }

    [JsonProperty("Genero")]
    public string Genero { get; set; }

}
