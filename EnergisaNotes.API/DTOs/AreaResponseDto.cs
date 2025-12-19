namespace EnergisaNotes.API.DTOs;

public record EmpresaDto(int Id, string Nome);

public record AreaResponseDto(
    int Id,
    string Nome,
    int? CoordenadorId,     
    string NomeCoordenador,
    List<EmpresaDto> Empresas
);