using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using EnergisaNotes.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EnergisaNotes.Infra.Repositories;
public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<Usuario?> ObterPorAzureIdAsync(string azureAdId)
    {
        return await _context.Usuarios
            .Include(u => u.Colaborador)
                .ThenInclude(c => c.Area)
            .Include(u => u.Colaborador)
                .ThenInclude(c => c.Cargo)
            .FirstOrDefaultAsync(u => u.AzureAdObjectId == azureAdId);
    }
}