using TFU5.Domain.Competencia;

namespace TFU5.Domain;

public class PuntuacionIndividual(CompetenciaIndividual competencia, Atleta atleta) : IPuntuacion
{
    public ICompetencia Competencia { get; private set; } = competencia;

    public List<ISubPuntuacion> SubPuntuaciones { get; private set; } = [];

    public Atleta Atleta { get; private set; } = atleta;

    public void Add(ISubPuntuacion sub_puntuacion)
    {
        SubPuntuaciones.Add(sub_puntuacion);
    }
}