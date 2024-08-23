namespace LibraryManagement.Domain.Entities;

public class Usuario
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string DocumentoIdentidad { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }
    public string Ubigeo { get; set; }
}
