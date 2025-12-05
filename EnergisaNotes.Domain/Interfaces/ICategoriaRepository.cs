using EnergisaNotes.Domain.Entities;

namespace EnergisaNotes.Domain.Interfaces;

public interface ICategoriaRepository : IBaseRepository<Categoria>
{
    // Método específico para validar se já existe uma categoria com esse nome
    // Útil para validação antes de inserir
    Task<bool> ExisteNomeAsync(string nome);
}