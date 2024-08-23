namespace LibraryManagement.Domain.Entities;

public class Prestamo
{
    public int ID { get; set; }
    public int UsuarioID { get; set; }
    public int CopiaID { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucion { get; set; }
    public int EstadoID { get; set; }

    public Usuario Usuario { get; set; }
    public Copia Copia { get; set; }
    public EstadoPrestamo Estado { get; set; }
}
