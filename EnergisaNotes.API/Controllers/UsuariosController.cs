using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace EnergisaNotes.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepo;

    public UsuariosController(IUsuarioRepository usuarioRepo)
    {
        _usuarioRepo = usuarioRepo;
    }

    [HttpGet("me")]
    public async Task<ActionResult<Usuario>> GetMyProfile()
    {
        var azureId = User.GetObjectId();
        if (string.IsNullOrEmpty(azureId)) return Unauthorized("Token inválido: ID não encontrado.");

        var usuario = await _usuarioRepo.ObterPorAzureIdAsync(azureId);

       
        if (usuario == null)
        {
      
            var email = User.Claims.FirstOrDefault(c => c.Type == "email")?.Value
                        ?? User.Claims.FirstOrDefault(c => c.Type == "preferred_username")?.Value
                        ?? User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(email))
            {
                email = $"{azureId}@energisa.com.br"; 
            }

            var nome = User.Claims.FirstOrDefault(c => c.Type == "name")?.Value ?? "Novo Usuário";

       
            int areaPadraoId = 1;
            int cargoPadraoId = 1;

            try
            {
                usuario = new Usuario(azureId, nome, email, areaPadraoId, cargoPadraoId, isSupervisor: false);

                await _usuarioRepo.AdicionarAsync(usuario);
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"Erro ao criar usuário: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno ao cadastrar usuário: {ex.Message}");
            }
        }

        return Ok(usuario);
    }
}