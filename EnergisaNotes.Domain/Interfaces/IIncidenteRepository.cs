using EnergisaNotes.Domain.Entities;

namespace EnergisaNotes.Domain.Interfaces;

public interface IIncidenteRepository : IBaseRepository<Incidente>
{
    // Método específico que não tem no genérico (ex: filtrar por categoria)
    Task<IEnumerable<Incidente>> ObterPorCategoriaAsync(int categoriaId);
}