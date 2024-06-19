using TFU5.Domain.Competencia;

namespace TFU5.Domain;

public class PuntuacionEquipo(CompetenciaEquipo competencia, Equipo equipo) : IPuntuacion
{
    public ICompetencia Competencia { get; private set; } = competencia;

    public List<ISubPuntuacion> SubPuntuaciones { get; private set; } = [];

    public Equipo Equipo { get; private set; } = equipo;

    public void Add(ISubPuntuacion sub_puntuacion)
    {
        SubPuntuaciones.Add(sub_puntuacion);
    }
}