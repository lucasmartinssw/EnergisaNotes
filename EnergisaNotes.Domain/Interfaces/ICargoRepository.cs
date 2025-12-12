using EnergisaNotes.Domain.Entities;

namespace EnergisaNotes.Domain.Interfaces;

public interface ICargoRepository
{
    // Apenas a leitura da lista por enquanto
    Task<IEnumerable<Cargo>> ObterTodosAsync();
}