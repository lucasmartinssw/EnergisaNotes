using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using EnergisaNotes.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EnergisaNotes.Infra.Repositories;

public class AreaRepository : IAreaRepository
{
    private readonly AppDbContext _context;

    public AreaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Area>> ObterTodasAsync()
    {
        return await _context.Areas
                             .AsNoTracking()
                             .OrderBy(a => a.Nome)
                             .ToListAsync();
    }

    public async Task<Area?> ObterPorIdAsync(int id)
    {
        return await _context.Areas.FindAsync(id);
    }
}