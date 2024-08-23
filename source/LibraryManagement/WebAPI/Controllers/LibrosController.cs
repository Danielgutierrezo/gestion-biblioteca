using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LibrosController : ControllerBase
{
    private readonly ILibroService _libroService;

    public LibrosController(ILibroService libroService)
    {
        _libroService = libroService;
    }

    [HttpPost]
    public async Task<IActionResult> AddLibro([FromBody] LibroDto libro)
    {
        await _libroService.AddLibroAsync(libro);
        return CreatedAtAction(nameof(AddLibro), new { id = libro.ID }, libro);
    }
}
