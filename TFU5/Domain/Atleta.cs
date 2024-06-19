namespace TFU5.Domain;

public class Atleta
{
    public Guid Id { get; set; } = new();

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public Genero Genero { get; set; }
}