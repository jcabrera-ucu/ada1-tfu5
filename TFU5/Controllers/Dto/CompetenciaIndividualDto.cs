using TFU5.Domain;
using TFU5.Domain.Competencia;

namespace TFU5;


public class CompetenciaIndividualDto
{
    public Guid Id { get; set; }

    public DisciplinaDto Disciplina { get; set; }

    public Categoria Categoria { get; set; }

    public DateOnly Fecha { get; set; }

    public List<Juez> Jueces { get; set; }

    public List<Atleta> Atletas { get; set; }

    public List<CompetenciaPuntuacionDto> Puntuaciones { get; set; } = [];

    public CompetenciaIndividualDto(CompetenciaIndividual competencia)
    {
        Id = competencia.Id;
        Disciplina = new DisciplinaDto(competencia.Disciplina);
        Categoria = competencia.Categoria;
        Fecha = competencia.Fecha;
        Jueces = competencia.Jueces;
        Atletas = competencia.Atletas;

        var visitor = new SubPuntuacionVisitor();

        foreach (var puntuacion in competencia.Puntuaciones)
        {
            foreach (var sub in puntuacion.SubPuntuaciones)
            {
                sub.Accept(visitor);
            }
        }

        Puntuaciones = visitor.Puntuaciones;
    }
}