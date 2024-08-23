using LibraryManagement.Application.DTOs;

namespace LibraryManagement.Application.Interfaces;

public interface ILibroService
{
    Task AddLibroAsync(LibroDto libro);    
}
