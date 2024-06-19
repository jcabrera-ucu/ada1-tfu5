namespace TFU5.Domain;

public class Juez(string nombre, 
                  string apellido, 
                  List<IDisciplina> disciplinas)
{
    public string Nombre { get; set; } = nombre;

    public string Apellido { get; set; } = apellido;

    public List<IDisciplina> Disciplinas { get; set; } = disciplinas;
}