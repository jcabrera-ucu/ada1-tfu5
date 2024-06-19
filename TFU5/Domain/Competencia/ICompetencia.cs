namespace TFU5.Domain;


public interface ICompetencia
{
    public Guid Id { get; set; }

    public Disciplina Disciplina { get; set; }

    public Categoria Categoria { get; set; }

    public List<Juez> Jueces { get; set; }

    public DateOnly Fecha { get; set; }

    public void AgregarPuntuacion(IPuntuacion puntuacion);

    // public bool PerteneceAtleta(Atleta atleta);
    // public bool PerteneceEquipo(Equipo equipo);
}