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
    private readonly IColaboradorRepository _colaboradorRepo; // Nova dependência

    // Injeção de Dependência: Precisamos dos dois repositórios agora
    public UsuariosController(IUsuarioRepository usuarioRepo, IColaboradorRepository colaboradorRepo)
    {
        _usuarioRepo = usuarioRepo;
        _colaboradorRepo = colaboradorRepo;
    }

    [HttpGet("me")]
    public async Task<ActionResult<Usuario>> GetMyProfile()
    {
        // 1. Validar Token
        var azureId = User.GetObjectId();
        if (string.IsNullOrEmpty(azureId)) return Unauthorized("Token inválido: ID não encontrado.");

        // 2. Tentar login normal (Usuário já existe?)
        var usuario = await _usuarioRepo.ObterPorAzureIdAsync(azureId);

        // 3. Se não existe, inicia o processo de Auto-Provisioning (Primeiro Acesso)
        if (usuario == null)
        {
            // Extração de dados do Token
            var email = User.Claims.FirstOrDefault(c => c.Type == "email")?.Value
                        ?? User.Claims.FirstOrDefault(c => c.Type == "preferred_username")?.Value
                        ?? User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(email))
            {
                // Fallback de segurança apenas
                email = $"{azureId}@energisa.com.br";
            }

            var nome = User.Claims.FirstOrDefault(c => c.Type == "name")?.Value ?? "Novo Usuário";

            try
            {
                // --- AQUI ESTÁ A MÁGICA DO VÍNCULO ---

                // Passo A: Verifica se já existe um Colaborador (Ficha do RH) com esse e-mail
                var colaborador = await _colaboradorRepo.ObterPorEmailAsync(email);

                if (colaborador == null)
                {
                    // CENÁRIO 1: Colaborador NOVO (Não existia na base)
                    // Criamos a ficha dele agora com dados padrão.
                    int areaPadraoId = 1; // Corporativo
                    int cargoPadraoId = 1; // Colaborador

                    colaborador = new Colaborador(nome, email, areaPadraoId, cargoPadraoId);

                    // Salvamos para gerar o ID (MySQL gera o ID nessa hora)
                    await _colaboradorRepo.AdicionarAsync(colaborador);
                }

                // Passo B: Cria o Usuário (Crachá de Acesso) apontando para o Colaborador (ID)
                usuario = new Usuario(azureId, colaborador.Id, isSupervisor: false);

                await _usuarioRepo.AdicionarAsync(usuario);

                // Opcional: Carregar os dados de navegação para retornar completo no JSON
                // usuario.Colaborador = colaborador; 
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"Erro de validação ao criar usuário: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno ao vincular colaborador: {ex.Message}");
            }
        }

        return Ok(usuario);
    }
}