namespace EnergisaNotes.Domain.Entities;

public class Area : BaseEntity
{
    public string Nome { get; private set; }

    // Propriedade de Navegação (EF Core)
    public virtual ICollection<Usuario> Usuarios { get; private set; }

    protected Area() { }

    public Area(string nome)
    {
        Validar(nome);
        Nome = nome;
    }

    public void Atualizar(string novoNome)
    {
        Validar(novoNome);
        Nome = novoNome;
        AtualizarTimestamp(); // Método herdado de BaseEntity
    }

    private void Validar(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome da área é obrigatório.");

        if (nome.Length < 3)
            throw new ArgumentException("O nome da área deve ter no mínimo 3 caracteres.");
    }
}