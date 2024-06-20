namespace TFU5.Domain.Competencia;

public class CompetenciaEquipo(Disciplina disciplina, 
                               Categoria categoria, 
                               DateOnly fecha, 
                               List<Equipo> equipos,
                               List<Juez> jueces) : ICompetencia
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Disciplina Disciplina { get; set; } = disciplina;

    public Categoria Categoria { get; set; } = categoria;

    public DateOnly Fecha { get; set; } = fecha;

    public List<Juez> Jueces { get; set; } = jueces;

    public List<Equipo> Equipos { get; set; } = equipos;

    public List<IPuntuacion> Puntuaciones { get; private set; } = [];

    public bool PerteneceAtleta(Guid id)
    {
        foreach (var equipo in Equipos)
        {
            if (equipo.Atletas.Find(x => x.Id == id) != null)
            {
                return true;
            }
        }

        return false;
    }

    public bool PerteneceEquipo(Guid id)
    {
        return Equipos.Find(x => x.Id == id) != null;
    }

    public void AgregarPuntuacion(IPuntuacion puntuacion)
    {
        Puntuaciones.Add(puntuacion);
    }
}
