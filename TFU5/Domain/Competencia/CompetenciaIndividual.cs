namespace TFU5.Domain.Competencia;

public class CompetenciaIndividual(Disciplina disciplina, 
                                   Categoria categoria, 
                                   DateOnly fecha, 
                                   List<Atleta> atletas,
                                   List<Juez> jueces) : ICompetencia
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Disciplina Disciplina { get; set; } = disciplina;

    public Categoria Categoria { get; set; } = categoria;

    public DateOnly Fecha { get; set; } = fecha;

    public List<Juez> Jueces { get; set; } = jueces;

    public List<Atleta> Atletas { get; set; } = atletas;

    public List<IPuntuacion> Puntuaciones { get; private set; } = [];

    public bool PerteneceAtleta(Guid id)
    {
        return Atletas.Find(x => x.Id == id) != null;
    }

    public bool PerteneceEquipo(Guid id)
    {
        return false;
    }

    public void AgregarPuntuacion(IPuntuacion puntuacion)
    {
        Puntuaciones.Add(puntuacion);
    }
}
