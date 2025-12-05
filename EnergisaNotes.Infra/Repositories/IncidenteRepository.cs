using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using EnergisaNotes.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EnergisaNotes.Infra.Repositories;

public class IncidenteRepository : BaseRepository<Incidente>, IIncidenteRepository
{
    public IncidenteRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Incidente>> ObterPorCategoriaAsync(int categoriaId)
    {
        return await _context.Incidentes
            .AsNoTracking()
            .Include(i => i.Categoria) // Join
            .Where(i => i.CategoriaId == categoriaId)
            .OrderByDescending(i => i.DataAtualizacao)
            .ToListAsync();
    }

    // Sobrescrevendo o ObterTodos para incluir a Categoria no Join
    public new async Task<IEnumerable<Incidente>> ObterTodosAsync()
    {
        return await _context.Incidentes
            .AsNoTracking()
            .Include(i => i.Categoria)
            .OrderByDescending(i => i.DataAtualizacao)
            .ToListAsync();
    }
}