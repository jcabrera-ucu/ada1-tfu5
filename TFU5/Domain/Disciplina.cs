namespace TFU5.Domain;

public interface IDisciplina
{
    public string Nombre { get; }

    public List<ISubPuntuacion> SubPuntuaciones { get; }
}

public class Disciplina(string nombre, 
                        List<ISubPuntuacion> sub_puntuaciones) : IDisciplina
{
    public string Nombre { get; private set; } = nombre;

    public List<ISubPuntuacion> SubPuntuaciones { get; private set; } = sub_puntuaciones;
}
