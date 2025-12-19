using System.Text.Json.Serialization;

namespace EnergisaNotes.Domain.Entities;

public class Cargo : BaseEntity
{
    public string Nome { get; private set; }

    [JsonIgnore]
    public virtual ICollection<Colaborador> Colaboradores { get; private set; }

    [JsonIgnore]
    public virtual ICollection<Usuario> Usuarios { get; private set; }

    protected Cargo() { }

    public Cargo(string nome)
    {
        Validar(nome);
        Nome = nome;
        Colaboradores = new List<Colaborador>();
        Usuarios = new List<Usuario>();
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
            throw new ArgumentException("O nome do cargo é obrigatório.");

        if (nome.Length < 3)
            throw new ArgumentException("O nome do cargo deve ter no mínimo 3 caracteres.");
    }
}