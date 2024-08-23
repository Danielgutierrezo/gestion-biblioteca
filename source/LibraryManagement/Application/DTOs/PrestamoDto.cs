namespace LibraryManagement.Application.DTOs;

public class PrestamoDto
{
    public int ID { get; set; }
    public int UsuarioID { get; set; }
    public int CopiaID { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucion { get; set; }
    public int EstadoID { get; set; }
}
