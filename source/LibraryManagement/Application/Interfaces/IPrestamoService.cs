using LibraryManagement.Application.DTOs;

namespace LibraryManagement.Application.Interfaces;

public interface IPrestamoService
{
    Task AddPrestamoAsync(PrestamoDto prestamo);
}
