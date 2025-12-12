namespace EnergisaNotes.Domain.Entities;

public class Usuario : BaseEntity
{
    public string AzureAdObjectId { get; private set; }
    public bool IsSupervisor { get; private set; }

    // O Usuário OBRIGATORIAMENTE pertence a um Colaborador
    public int ColaboradorId { get; private set; }
    public virtual Colaborador Colaborador { get; private set; }

    protected Usuario() { }

    public Usuario(string azureId, int colaboradorId, bool isSupervisor)
    {
        if (string.IsNullOrWhiteSpace(azureId)) throw new ArgumentException("Azure ID obrigatório");
        if (colaboradorId <= 0) throw new ArgumentException("Colaborador inválido");

        AzureAdObjectId = azureId;
        ColaboradorId = colaboradorId;
        IsSupervisor = isSupervisor;
    }
}