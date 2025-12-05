using System.ComponentModel.DataAnnotations;

namespace EnergisaNotes.API.DTOs;

// O que o Front manda para criar
public record CriarIncidenteDto(
    [Required] string Titulo,
    [Required] string TextoTemplate,
    [Required] int CategoriaId
);

// O que o Front manda para atualizar
public record AtualizarIncidenteDto(
    [Required] string Titulo,
    [Required] string TextoTemplate,
    [Required] int CategoriaId
);

// O que a API devolve para o Front (Visualização limpa)
public record IncidenteResponseDto(
    int Id,
    string Titulo,
    string TextoTemplate,
    string CategoriaNome,
    string? UltimoEditorNome,
    DateTime? DataAtualizacao
);