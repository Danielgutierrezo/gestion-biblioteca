using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.Data;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

    public DbSet<Libro> Libros { get; set; }
    public DbSet<Copia> Copias { get; set; }
    public DbSet<Prestamo> Prestamos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<EstadoPrestamo> EstadosPrestamos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Configuraciones adicionales si es necesario
    }
}
