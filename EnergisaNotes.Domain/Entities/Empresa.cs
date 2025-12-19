using System.Text.Json.Serialization;

namespace EnergisaNotes.Domain.Entities;

public class Empresa : BaseEntity
{
    public string Nome { get; private set; }

    [JsonIgnore]
    public virtual ICollection<Area> Areas { get; private set; } 

    protected Empresa() { }

    public Empresa(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome inválido");
        Nome = nome;
    }
}