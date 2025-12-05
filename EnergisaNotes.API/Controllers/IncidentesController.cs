using EnergisaNotes.API.DTOs;
using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace EnergisaNotes.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class IncidentesController : ControllerBase
{
    private readonly IIncidenteRepository _incidenteRepo;
    private readonly IUsuarioRepository _usuarioRepo;

    public IncidentesController(IIncidenteRepository incidenteRepo, IUsuarioRepository usuarioRepo)
    {
        _incidenteRepo = incidenteRepo;
        _usuarioRepo = usuarioRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IncidenteResponseDto>>> ObterTodos()
    {
        var incidentes = await _incidenteRepo.ObterTodosAsync();

        // Mapeamento Entidade -> DTO
        var dtos = incidentes.Select(i => new IncidenteResponseDto(
            i.Id,
            i.Titulo,
            i.TextoTemplate,
            i.Categoria?.Nome ?? "Sem Categoria",
            i.UltimoEditor?.Nome ?? "Desconhecido",
            i.DataAtualizacao
        ));

        return Ok(dtos);
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarIncidenteDto dto)
    {
        // 1. Identificar Usuário Logado (Supervisor?)
        var (usuario, erro) = await ObterUsuarioLogado();
        if (usuario == null) return Unauthorized(erro);
        if (!usuario.IsSupervisor) return Forbid();

        // 2. Criar Entidade de Domínio
        try
        {
            var novoIncidente = new Incidente(dto.Titulo, dto.TextoTemplate, dto.CategoriaId, usuario.Id);
            await _incidenteRepo.AdicionarAsync(novoIncidente);

            return CreatedAtAction(nameof(ObterTodos), new { id = novoIncidente.Id }, dto);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message); // Retorna erro de validação do Domínio
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] AtualizarIncidenteDto dto)
    {
        var (usuario, erro) = await ObterUsuarioLogado();
        if (usuario == null) return Unauthorized(erro);
        if (!usuario.IsSupervisor) return Forbid();

        var incidente = await _incidenteRepo.ObterPorIdAsync(id);
        if (incidente == null) return NotFound();

        // Atualiza a entidade de domínio
        try
        {
            incidente.Atualizar(dto.Titulo, dto.TextoTemplate, usuario.Id, dto.CategoriaId);
            await _incidenteRepo.AtualizarAsync(incidente);
            return NoContent();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // Helper para pegar usuário logado
    private async Task<(Usuario?, string?)> ObterUsuarioLogado()
    {
        var azureId = User.GetObjectId();
        if (string.IsNullOrEmpty(azureId)) return (null, "Token inválido");

        var usuario = await _usuarioRepo.ObterPorAzureIdAsync(azureId);
        return (usuario, null); // Se null, o middleware de UserSync (futuro) ou o front deve tratar
    }
}