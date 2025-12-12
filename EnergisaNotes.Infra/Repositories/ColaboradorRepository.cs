using EnergisaNotes.Domain.Entities;
using EnergisaNotes.Domain.Interfaces;
using EnergisaNotes.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EnergisaNotes.Infra.Repositories;

public class ColaboradorRepository : IColaboradorRepository
{
    private readonly AppDbContext _context;

    public ColaboradorRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Colaborador>> ObterTodosAsync()
    {
        return await _context.Colaboradores
            .AsNoTracking() 
            .Include(c => c.Area)  
            .Include(c => c.Cargo) 
            .OrderBy(c => c.Nome)  
            .ToListAsync();
    }
    public async Task<Colaborador?> ObterPorEmailAsync(string email)
    {
        return await _context.Colaboradores
                             .FirstOrDefaultAsync(c => c.Email == email);
    }

    public async Task AdicionarAsync(Colaborador colaborador)
    {
        await _context.Colaboradores.AddAsync(colaborador);
        await _context.SaveChangesAsync();
    }
}