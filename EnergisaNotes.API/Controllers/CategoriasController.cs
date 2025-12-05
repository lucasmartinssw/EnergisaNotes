using EnergisaNotes.API.DTOs;
using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace EnergisaNotes.API.Controllers;

//[Authorize]
[ApiController]
[Route("api/[controller]")]
public class CategoriasController : ControllerBase
{
    private readonly ICategoriaRepository _categoriaRepo;
    private readonly IUsuarioRepository _usuarioRepo;

    public CategoriasController(ICategoriaRepository categoriaRepo, IUsuarioRepository usuarioRepo)
    {
        _categoriaRepo = categoriaRepo;
        _usuarioRepo = usuarioRepo;
    }

    // GET: api/categorias
    // Aberto para todos os usuários logados (para preencher dropdowns)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoriaResponseDto>>> ObterTodas()
    {
        var categorias = await _categoriaRepo.ObterTodosAsync();

        // Mapeamento Entidade -> DTO
        var dtos = categorias.Select(c => new CategoriaResponseDto(c.Id, c.Nome));

        return Ok(dtos);
    }

    // POST: api/categorias
    // Restrito: Apenas Supervisores
    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarCategoriaDto dto)
    {
        // 1. Verificação de Permissão (Supervisor)
        var azureId = User.GetObjectId();
        if (string.IsNullOrEmpty(azureId)) return Unauthorized();

        var usuario = await _usuarioRepo.ObterPorAzureIdAsync(azureId);
        if (usuario == null || !usuario.IsSupervisor)
        {
            return StatusCode(403, "Acesso negado: Apenas supervisores podem criar categorias.");
        }

        // 2. Validação de Regra de Negócio: Nome Único
        if (await _categoriaRepo.ExisteNomeAsync(dto.Nome))
        {
            return Conflict($"A categoria '{dto.Nome}' já existe.");
        }

        try
        {
            // 3. Criação da Entidade de Domínio
            var novaCategoria = new Categoria(dto.Nome);

            await _categoriaRepo.AdicionarAsync(novaCategoria);

            // Retorna 201 Created com o DTO de resposta
            return CreatedAtAction(
                nameof(ObterTodas),
                new { id = novaCategoria.Id },
                new CategoriaResponseDto(novaCategoria.Id, novaCategoria.Nome)
            );
        }
        catch (ArgumentException ex)
        {
            // Captura validações da Entidade (ex: nome muito curto)
            return BadRequest(ex.Message);
        }
    }
}