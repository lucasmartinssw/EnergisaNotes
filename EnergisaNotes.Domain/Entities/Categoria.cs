namespace EnergisaNotes.Domain.Entities;

public class Categoria : BaseEntity
{
    public string Nome { get; private set; }

    protected Categoria() { }

    public Categoria(string nome)
    {
        Validar(nome);
        Nome = nome;
    }

    public void Atualizar(string novoNome)
    {
        Validar(novoNome);
        Nome = novoNome;
        AtualizarTimestamp();
    }

    private void Validar(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome da categoria é obrigatório.");

        if (nome.Length < 3)
            throw new ArgumentException("O nome da categoria deve ter no mínimo 3 caracteres.");
    }
}