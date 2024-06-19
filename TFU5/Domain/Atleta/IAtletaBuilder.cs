namespace TFU5.Domain;

public interface IAtletaBuilder
{
    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public DateOnly FechaDeNacimiento { get; set; }

    public Pais Pais { get; set; }

    public Genero Genero { get; set; }

    public List<Disciplina> Disciplinas { get; set; }

    public Atleta Build();
}
