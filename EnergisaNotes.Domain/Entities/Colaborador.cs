using System.Text.Json.Serialization;

namespace EnergisaNotes.Domain.Entities;

public class Colaborador : BaseEntity
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string? Telefone { get; private set; }

    // --- NOVOS CAMPOS ---
    public string? Endereco { get; private set; }
    public string? Empresa { get; private set; } // Ex: "Energisa Tocantins"
    public string? Aniversario { get; private set; } // Formato: "DD/MM" (Ex: "25/12")

    // Vínculos
    public int AreaId { get; private set; }
    public virtual Area Area { get; private set; }

    public int CargoId { get; private set; }
    public virtual Cargo Cargo { get; private set; }

    [JsonIgnore]
    public virtual Usuario? Usuario { get; private set; }

    protected Colaborador() { }

    public Colaborador(string nome, string email, int areaId, int cargoId)
    {
        Validar(nome, email, areaId, cargoId);
        Nome = nome;
        Email = email;
        AreaId = areaId;
        CargoId = cargoId;
    }

    // Método para atualizar o perfil completo
    public void AtualizarDados(string nome, string? telefone, string? endereco, string? empresa, string? aniversario)
    {
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome inválido");

        Nome = nome;
        Telefone = telefone;
        Endereco = endereco;
        Empresa = empresa;
        Aniversario = aniversario; // O front deve mandar a string pronta "DD/MM"
        AtualizarTimestamp();
    }

    private void Validar(string nome, string email, int areaId, int cargoId)
    {
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome obrigatório");
        if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email obrigatório");
        if (areaId <= 0) throw new ArgumentException("Área inválida");
        if (cargoId <= 0) throw new ArgumentException("Cargo inválido");
    }
}