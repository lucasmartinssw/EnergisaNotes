namespace EnergisaNotes.Domain.Entities;

public class Incidente : BaseEntity
{
    public string Titulo { get; private set; }
    public string TextoTemplate { get; private set; }

    // Relacionamentos (Foreign Keys)
    public int CategoriaId { get; private set; }
    public virtual Categoria? Categoria { get; private set; } // Virtual para Lazy Loading se precisar

    public int? UltimoEditorId { get; private set; }
    public virtual Usuario? UltimoEditor { get; private set; }

    protected Incidente() { }

    public Incidente(string titulo, string textoTemplate, int categoriaId, int criadorId)
    {
        Validar(titulo, textoTemplate);
        Titulo = titulo;
        TextoTemplate = textoTemplate;
        CategoriaId = categoriaId;
        UltimoEditorId = criadorId; // Quem cria é o primeiro editor
    }

    public void Atualizar(string novoTitulo, string novoTexto, int novoEditorId, int novaCategoriaId)
    {
        Validar(novoTitulo, novoTexto);
        Titulo = novoTitulo;
        TextoTemplate = novoTexto;
        CategoriaId = novaCategoriaId;
        UltimoEditorId = novoEditorId;
        AtualizarTimestamp();
    }

    private void Validar(string titulo, string texto)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("O título do incidente é obrigatório.");

        if (string.IsNullOrWhiteSpace(texto))
            throw new ArgumentException("O texto do template é obrigatório.");

        if (!texto.Contains("[") || !texto.Contains("]"))
            throw new ArgumentException("O template deve conter pelo menos uma variável entre colchetes, ex: [Hora].");
    }
}