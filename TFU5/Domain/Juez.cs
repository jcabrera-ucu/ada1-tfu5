namespace TFU5.Domain;

public class Juez(string nombre, 
                  string apellido, 
                  List<IDisciplina> disciplinas)
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Nombre { get; set; } = nombre;

    public string Apellido { get; set; } = apellido;

    public List<IDisciplina> Disciplinas { get; set; } = disciplinas;
}