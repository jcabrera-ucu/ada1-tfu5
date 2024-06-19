using TFU5.Domain;
using TFU5.Domain.Competencia;

namespace TFU5;


public class AtletaDto(Atleta atleta)
{    
    public Guid Id { get; set; } = atleta.Id;

    public string Nombre { get; set; } = atleta.Nombre;

    public string Apellido { get; set; } = atleta.Apellido;

    public DateOnly FechaDeNacimiento { get; set; } = atleta.FechaDeNacimiento;

    public Pais Pais { get; set; } = atleta.Pais;

    public Genero Genero { get; set; } = atleta.Genero;

    public List<DisciplinaDto> Disciplinas { get; set; } = atleta.Disciplinas
        .Select(x => new DisciplinaDto(x))
        .ToList();
}