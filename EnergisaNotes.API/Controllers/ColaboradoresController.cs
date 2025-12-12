using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnergisaNotes.API.Controllers;

//[Authorize] 
[ApiController]
[Route("api/[controller]")]
public class ColaboradoresController : ControllerBase
{
    private readonly IColaboradorRepository _colaboradorRepo;

    public ColaboradoresController(IColaboradorRepository colaboradorRepo)
    {
        _colaboradorRepo = colaboradorRepo;
    }

    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Colaborador>>> GetAll()
    {
        var colaboradores = await _colaboradorRepo.ObterTodosAsync();
        return Ok(colaboradores);
    }
}