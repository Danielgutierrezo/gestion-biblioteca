using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Data;

namespace LibraryManagement.Infrastructure.Repositories
{
    public class PrestamoRepository : IPrestamoService
    {
        private readonly LibraryContext _context;

        public PrestamoRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task AddPrestamoAsync(PrestamoDto prestamoDto)
        {
            var prestamo = new Prestamo
            {
                UsuarioID = prestamoDto.UsuarioID,
                CopiaID = prestamoDto.CopiaID,
                FechaPrestamo = prestamoDto.FechaPrestamo,
                FechaDevolucion = prestamoDto.FechaDevolucion,
                EstadoID = prestamoDto.EstadoID
            };

            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();
        }
    }
}
