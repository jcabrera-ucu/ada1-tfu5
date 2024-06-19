namespace TFU5.Domain;

public class Atleta(string nombre,
                    string apellido,
                    DateOnly fecha,
                    Pais pais,
                    Genero genero,
                    List<Disciplina> disciplinas)
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Nombre { get; set; } = nombre;

    public string Apellido { get; set; } = apellido;

    public DateOnly FechaDeNacimiento { get; set; } = fecha;

    public Pais Pais { get; set; } = pais;

    public Genero Genero { get; set; } = genero;

    public List<Disciplina> Disciplinas { get; set; } = disciplinas;
}