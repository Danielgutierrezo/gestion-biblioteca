using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Data;

namespace LibraryManagement.Infrastructure.Repositories;

public class LibroRepository : ILibroService
{
    private readonly LibraryContext _context;

    public LibroRepository(LibraryContext context)
    {
        _context = context;
    }

    public async Task AddLibroAsync(LibroDto libroDto)
    {
        var libro = new Libro
        {
            Titulo = libroDto.Titulo,
            Autor = libroDto.Autor,
            Categoria = libroDto.Categoria,
            ISBN = libroDto.ISBN
        };

        _context.Libros.Add(libro);
        await _context.SaveChangesAsync();

        // Agregar una copia del libro automáticamente
        var copia = new Copia
        {
            LibroID = libro.ID,
            CodigoBarras = $"CB{libro.ID:D4}", // Generar un código de barras
            EstadoID = 1 // Estado 'Disponible'
        };

        _context.Copias.Add(copia);
        await _context.SaveChangesAsync();
    }
}
