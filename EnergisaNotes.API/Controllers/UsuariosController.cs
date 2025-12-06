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

        // Se não existir no banco, cria (Auto-Provisioning)
        if (usuario == null)
        {
            // --- AJUSTE AQUI ---
            // Buscamos explicitamente pela claim com a chave "email"
            var email = User.Claims.FirstOrDefault(c => c.Type == "email")?.Value
                        ?? User.Claims.FirstOrDefault(c => c.Type == "preferred_username")?.Value
                        // Fallback para o padrão do .NET (URL longa)
                        ?? User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;

            // Se mesmo assim vier vazio (ex: token de teste mal configurado),
            // colocamos um valor provisório para não quebrar a Regra de Negócio do Domínio
            if (string.IsNullOrEmpty(email))
            {
                email = $"{azureId}@energisa.com.br"; // Gera um email fake baseado no ID
            }

            var nome = User.Claims.FirstOrDefault(c => c.Type == "name")?.Value ?? "Novo Usuário";

            try
            {
                usuario = new Usuario(azureId, nome, email, isSupervisor: false);
                await _usuarioRepo.AdicionarAsync(usuario);
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"Erro ao criar usuário: {ex.Message}");
            }
        }

        return Ok(usuario);
    }
}