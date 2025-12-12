using EnergisaNotes.Domain.Entities;

namespace EnergisaNotes.Domain.Interfaces;

public interface IColaboradorRepository
{
    Task<IEnumerable<Colaborador>> ObterTodosAsync();
    Task<Colaborador?> ObterPorEmailAsync(string email);
    Task AdicionarAsync(Colaborador colaborador);
}