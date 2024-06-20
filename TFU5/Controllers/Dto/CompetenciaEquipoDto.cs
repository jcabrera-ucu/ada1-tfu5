using TFU5.Domain;
using TFU5.Domain.Competencia;

namespace TFU5;


/*lass SubPuntuacionVisitor : ISubPuntuacionVisitor
{
    public List<CompetenciaPuntuacionDto> Puntuaciones { get; set; } = [];

    public void VisitDistancia(PuntuacionDistancia distancia)
    {
        Puntuaciones.Add(new(PuntuacionDistancia.Identificador, distancia.DistanciaM.ToString()));
    }

    public void VisitTiempo(PuntuacionTiempo tiempo)
    {
        Puntuaciones.Add(new(PuntuacionTiempo.Identificador, tiempo.Segundos.ToString()));
    }
}*/

public class CompetenciaEquipoDto
{
    public Guid Id { get; set; }

    public DisciplinaDto Disciplina { get; set; }

    public Categoria Categoria { get; set; }

    public DateOnly Fecha { get; set; }

    public List<Juez> Jueces { get; set; }

    public List<Equipo> Equipos { get; set; }

    public List<CompetenciaPuntuacionDto> Puntuaciones { get; set; } = [];

    public CompetenciaEquipoDto(CompetenciaEquipo competencia)
    {
        Id = competencia.Id;
        Disciplina = new DisciplinaDto(competencia.Disciplina);
        Categoria = competencia.Categoria;
        Fecha = competencia.Fecha;
        Jueces = competencia.Jueces;
        Equipos = competencia.Equipos;

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