namespace EnergisaNotes.Domain.Entities;

public class Usuario : BaseEntity
{
    public string AzureAdObjectId { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public bool IsSupervisor { get; private set; }

    // --- MUDANÇA: Relacionamento com a Tabela Area ---
    public int AreaId { get; private set; }
    public virtual Area Area { get; private set; } // Navegação

    // Dados Complementares (Mantive Cargo como string por enquanto, conforme solicitado)
    public string? Cargo { get; private set; }
    public string? TelefonePessoal { get; private set; }
    public string? Endereco { get; private set; }
    public DateTime? DataNascimento { get; private set; }

    protected Usuario() { }

    // O Construtor agora exige o ID da Área
    public Usuario(string azureId, string nome, string email, int areaId, bool isSupervisor = false)
    {
        Validar(azureId, nome, email, areaId);

        AzureAdObjectId = azureId;
        Nome = nome;
        Email = email;
        AreaId = areaId;
        IsSupervisor = isSupervisor;
    }

    // Método para alterar dados cadastrais básicos e movimentação de área
    public void AtualizarDadosPrincipais(string nome, int areaId, bool isSupervisor)
    {
        // Validamos apenas o que está sendo alterado
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome inválido");
        if (areaId <= 0) throw new ArgumentException("Área inválida");

        Nome = nome;
        AreaId = areaId;
        IsSupervisor = isSupervisor;
        AtualizarTimestamp();
    }

    // Método separado para dados opcionais (Note que removi 'Area' daqui)
    public void AtualizarDadosComplementares(string? cargo, string? telefone, string? endereco, DateTime? nascimento)
    {
        Cargo = cargo;
        TelefonePessoal = telefone;
        Endereco = endereco;
        DataNascimento = nascimento;
        AtualizarTimestamp();
    }

    private void Validar(string azureId, string nome, string email, int areaId)
    {
        if (string.IsNullOrWhiteSpace(azureId)) throw new ArgumentException("Azure ID é obrigatório.");
        if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email é obrigatório.");
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome é obrigatório.");

        // Garante que o usuário pertença a uma área válida
        if (areaId <= 0) throw new ArgumentException("O ID da Área é obrigatório e deve ser válido.");
    }
}