using System.ComponentModel.DataAnnotations;

namespace EnergisaNotes.API.DTOs;

public record CriarCategoriaDto([Required] string Nome);
public record CategoriaResponseDto(int Id, string Nome);