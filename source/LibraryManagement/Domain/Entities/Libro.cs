namespace LibraryManagement.Domain.Entities;

public class Libro
{
    public int ID { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Categoria { get; set; }
    public string ISBN { get; set; }
}
