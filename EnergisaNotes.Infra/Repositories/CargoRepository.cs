using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using EnergisaNotes.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EnergisaNotes.Infra.Repositories;

public class CargoRepository : ICargoRepository
{
    private readonly AppDbContext _context;

    public CargoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Cargo>> ObterTodosAsync()
    {
        // AsNoTracking deixa a consulta mais rápida (ótimo para listas)
        return await _context.Cargos
                             .AsNoTracking()
                             .OrderBy(c => c.Nome)
                             .ToListAsync();
    }
}