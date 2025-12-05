using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using EnergisaNotes.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EnergisaNotes.Infra.Repositories;

public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<bool> ExisteNomeAsync(string nome)
    {
        // O EF Core traduz isso para: SELECT CASE WHEN EXISTS...
        // É muito performático
        return await _dbSet.AnyAsync(c => c.Nome == nome);
    }
}