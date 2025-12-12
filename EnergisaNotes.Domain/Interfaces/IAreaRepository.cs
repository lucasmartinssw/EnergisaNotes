using EnergisaNotes.Domain.Entities;

namespace EnergisaNotes.Domain.Interfaces;

public interface IAreaRepository
{
    Task<IEnumerable<Area>> ObterTodasAsync();
    Task<Area?> ObterPorIdAsync(int id); 
}