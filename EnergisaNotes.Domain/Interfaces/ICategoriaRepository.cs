using EnergisaNotes.Domain.Entities;

namespace EnergisaNotes.Domain.Interfaces;

public interface ICategoriaRepository : IBaseRepository<Categoria>
{
    Task<bool> ExisteNomeAsync(string nome);
}