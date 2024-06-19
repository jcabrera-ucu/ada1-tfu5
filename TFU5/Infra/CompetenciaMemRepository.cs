using TFU5.Domain;
using TFU5.Data;
using TFU5.Domain.Competencia;

namespace TFU5.Infra;

public class CompetenciaMemRepository : ICompetenciaRepository
{
    private readonly Dictionary<Guid, CompetenciaIndividual> _individuales = [];

    private readonly Dictionary<Guid, CompetenciaEquipo> _equipos = [];

    public void Save(CompetenciaIndividual competencia)
    {
        _individuales.Add(competencia.Id, competencia);
    }

    public void Save(CompetenciaEquipo competencia)
    {
        _equipos.Add(competencia.Id, competencia);
    }

    public List<CompetenciaIndividual> ListIndividuales()
    {
        return [.. _individuales.Values];
    }

    public List<CompetenciaEquipo> ListEquipos()
    {
        return [.. _equipos.Values];
    }
}
