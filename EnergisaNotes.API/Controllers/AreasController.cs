using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnergisaNotes.API.Controllers;

//[Authorize]
[ApiController]
[Route("api/[controller]")]
public class AreasController : ControllerBase
{
    private readonly IAreaRepository _areaRepo;

    public AreasController(IAreaRepository areaRepo)
    {
        _areaRepo = areaRepo;
    }

 
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Area>>> GetAll()
    {
        var areas = await _areaRepo.ObterTodasAsync();
        return Ok(areas);
    }
}