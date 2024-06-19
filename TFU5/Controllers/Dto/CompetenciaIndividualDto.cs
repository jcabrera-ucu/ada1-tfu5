using TFU5.Domain;
using TFU5.Domain.Competencia;

namespace TFU5;


public class CompetenciaIndividualDto(CompetenciaIndividual competencia)
{
    public Guid Id { get; set; } = competencia.Id;

    public DisciplinaDto Disciplina { get; set; } = new DisciplinaDto(competencia.Disciplina);

    public Categoria Categoria { get; set; } = competencia.Categoria;

    public DateOnly Fecha { get; set; } = competencia.Fecha;

    public List<Juez> Jueces { get; set; } = competencia.Jueces;

    public List<Atleta> Atletas { get; set; } = competencia.Atletas;

    public List<IPuntuacion> Puntuaciones { get; set; } = competencia.Puntuaciones;
}