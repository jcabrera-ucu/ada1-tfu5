namespace TFU5.Domain.Competencia;

public class CompetenciaIndividual(Disciplina disciplina, 
                                   Categoria categoria, 
                                   DateOnly fecha, 
                                   List<Atleta> atletas) : ICompetencia
{
    public Disciplina Disciplina { get; set; } = disciplina;

    public Categoria Categoria { get; set; } = categoria;

    public DateOnly Fecha { get; set; } = fecha;

    public List<Atleta> Atletas { get; set; } = atletas;

    public List<IPuntuacion> Puntuaciones { get; private set; } = [];

    public void AgregarPuntuacion(IPuntuacion puntuacion)
    {
        Puntuaciones.Add(puntuacion);
    }
}
