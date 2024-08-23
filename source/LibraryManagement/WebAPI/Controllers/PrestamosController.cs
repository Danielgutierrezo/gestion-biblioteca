using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PrestamosController : ControllerBase
{
    private readonly IPrestamoService _prestamoService;

    public PrestamosController(IPrestamoService prestamoService)
    {
        _prestamoService = prestamoService;
    }

    [HttpPost]
    public async Task<IActionResult> AddPrestamo([FromBody] PrestamoDto prestamo)
    {
        await _prestamoService.AddPrestamoAsync(prestamo);
        return CreatedAtAction(nameof(AddPrestamo), new { id = prestamo.ID }, prestamo);
    }
}
