namespace EnergisaNotes.API.DTOs;

public record EmpresaDto(int Id, string Nome);

public record AreaResponseDto(
    int Id,
    string Nome,
    string Coordenacao,
    List<EmpresaDto> Empresas
);