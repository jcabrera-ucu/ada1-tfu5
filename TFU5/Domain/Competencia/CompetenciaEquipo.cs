namespace TFU5.Domain.Competencia;

public class CompetenciaEquipo(Disciplina disciplina, 
                               Categoria categoria, 
                               DateOnly fecha, 
                               List<Equipo> equipos) : ICompetencia
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Disciplina Disciplina { get; set; } = disciplina;

    public Categoria Categoria { get; set; } = categoria;

    public DateOnly Fecha { get; set; } = fecha;

    public List<Juez> Jueces { get; set; } = [];

    public List<Equipo> Equipos { get; set; } = equipos;

    public List<IPuntuacion> Puntuaciones { get; private set; } = [];

    public void AgregarPuntuacion(IPuntuacion puntuacion)
    {
        Puntuaciones.Add(puntuacion);
    }
}
