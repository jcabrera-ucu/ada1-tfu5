using TFU5.Domain;
using TFU5.Domain.Competencia;

namespace TFU5.Data;


public interface ICompetenciaRepository
{
    public CompetenciaIndividual? GetIndividual(Guid id);

    public CompetenciaEquipo? GetEquipo(Guid id);

    public void Save(CompetenciaEquipo competencia);

    public void Save(CompetenciaIndividual competencia);

    public List<CompetenciaIndividual> ListIndividuales();

    public List<CompetenciaEquipo> ListEquipos();
}