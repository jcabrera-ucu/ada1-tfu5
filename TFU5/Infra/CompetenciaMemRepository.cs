using TFU5.Domain;
using TFU5.Data;
using TFU5.Domain.Competencia;

namespace TFU5.Infra;

public class CompetenciaMemRepository : ICompetenciaRepository
{
    private readonly Dictionary<Guid, CompetenciaIndividual> _individuales = [];

    private readonly Dictionary<Guid, CompetenciaEquipo> _equipos = [];

    public CompetenciaIndividual? GetIndividual(Guid id)
    {
        if (_individuales.TryGetValue(id, out CompetenciaIndividual? competencia))
        {
            return competencia;
        }

        return null;
    }

    public CompetenciaEquipo? GetEquipo(Guid id)
    {
        if (_equipos.TryGetValue(id, out CompetenciaEquipo? competencia))
        {
            return competencia;
        }

        return null;
    }

    public void Save(CompetenciaIndividual competencia)
    {
        _individuales[competencia.Id] = competencia;
    }

    public void Save(CompetenciaEquipo competencia)
    {
        _equipos[competencia.Id] = competencia;
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
