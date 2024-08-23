namespace LibraryManagement.Domain.Entities;

public class Copia
{
    public int ID { get; set; }
    public int LibroID { get; set; }
    public string CodigoBarras { get; set; }
    public int EstadoID { get; set; }

    public Libro Libro { get; set; }
    public Estado Estado { get; set; }
}
