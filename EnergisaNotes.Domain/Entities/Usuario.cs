namespace EnergisaNotes.Domain.Entities;

public class Usuario : BaseEntity
{
    public string AzureAdObjectId { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public bool IsSupervisor { get; private set; }

    // Dados Complementares (Podem ser nulos inicialmente)
    public string? Cargo { get; private set; }
    public string? Area { get; private set; }
    public string? TelefonePessoal { get; private set; }
    public string? Endereco { get; private set; }
    public DateTime? DataNascimento { get; private set; }

    protected Usuario() { }

    public Usuario(string azureId, string nome, string email, bool isSupervisor = false)
    {
        if (string.IsNullOrWhiteSpace(azureId)) throw new ArgumentException("Azure ID inválido");
        if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email inválido");

        AzureAdObjectId = azureId;
        Nome = nome;
        Email = email;
        IsSupervisor = isSupervisor;
    }

    public void AtualizarDadosComplementares(string? cargo, string? area, string? telefone, string? endereco, DateTime? nascimento)
    {
        Cargo = cargo;
        Area = area;
        TelefonePessoal = telefone;
        Endereco = endereco;
        DataNascimento = nascimento;
        AtualizarTimestamp();
    }

    public void TornarSupervisor()
    {
        IsSupervisor = true;
        AtualizarTimestamp();
    }
}