namespace EnergisaNotes.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; protected set; }
    public DateTime DataCriacao { get; protected set; } = DateTime.UtcNow;
    public DateTime? DataAtualizacao { get; protected set; }

    protected void AtualizarTimestamp()
    {
        DataAtualizacao = DateTime.UtcNow;
    }
}