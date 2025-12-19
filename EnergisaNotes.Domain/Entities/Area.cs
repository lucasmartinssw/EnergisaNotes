using System.Text.Json.Serialization;

namespace EnergisaNotes.Domain.Entities;

public class Area : BaseEntity
{
    public string Nome { get; private set; }

    // --- MUDANÇA 1: Substituímos a string solta por uma referência forte ---
    public int? CoordenadorId { get; private set; } // O ID (banco de dados)
    public virtual Colaborador? Coordenador { get; private set; } // O Objeto (navegação)

    // Relacionamento N:N com Empresas
    public virtual ICollection<Empresa> Empresas { get; private set; }

    [JsonIgnore]
    public virtual ICollection<Colaborador> Colaboradores { get; private set; }

    [JsonIgnore]
    public virtual ICollection<Usuario> Usuarios { get; private set; }

    protected Area() { }

    // --- MUDANÇA 2: O Construtor agora pede o ID, não o nome ---
    public Area(string nome, int? coordenadorId)
    {
        Validar(nome);
        Nome = nome;
        CoordenadorId = coordenadorId; // Vínculo pelo ID

        // Inicialização de listas
        Empresas = new List<Empresa>();
        Colaboradores = new List<Colaborador>();
        Usuarios = new List<Usuario>();
    }

    // --- MUDANÇA 3: O método de atualizar também recebe o ID ---
    public void Atualizar(string novoNome, int? novoCoordenadorId)
    {
        Validar(novoNome);
        Nome = novoNome;
        CoordenadorId = novoCoordenadorId;
        AtualizarTimestamp();
    }

    private void Validar(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome da área é obrigatório.");

        if (nome.Length < 3)
            throw new ArgumentException("O nome da área deve ter no mínimo 3 caracteres.");
    }
}