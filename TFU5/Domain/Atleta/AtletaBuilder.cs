namespace TFU5.Domain;


public class AtletaBuilder : IAtletaBuilder
{
    public string Nombre { get; set; } = "";

    public string Apellido { get; set; } = "";

    public DateOnly FechaDeNacimiento { get; set; }

    public Pais Pais { get; set; }

    public Genero Genero { get; set; }

    public List<IDisciplina> Disciplinas { get; set; } = [];

    public Atleta Build()
    {
        return new Atleta(Nombre, Apellido, FechaDeNacimiento, Pais, Genero, Disciplinas);
    }
}
