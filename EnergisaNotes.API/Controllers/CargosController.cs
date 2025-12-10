using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnergisaNotes.API.Controllers;

//[Authorize] 
[ApiController]
[Route("api/[controller]")]
public class CargosController : ControllerBase
{
    private readonly ICargoRepository _cargoRepo;

    public CargosController(ICargoRepository cargoRepo)
    {
        _cargoRepo = cargoRepo;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cargo>>> GetAll()
    {
        var cargos = await _cargoRepo.ObterTodosAsync();
        return Ok(cargos);
    }
}