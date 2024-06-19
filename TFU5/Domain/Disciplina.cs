namespace TFU5.Domain;

public interface IDisciplina
{
    public string Nombre { get; }

    public List<ISubPuntuacion> SubPuntuaciones { get; }
}

public class Disciplina : IDisciplina
{
    public string Nombre { get; private set; }

    private List<ISubPuntuacion> _subPuntuaciones;

    public List<ISubPuntuacion> SubPuntuaciones 
    { 
        get 
        {
            return _subPuntuaciones.Select(x => x.Clone()).ToList();
        } 
        private set 
        { 
            _subPuntuaciones = value;
        } 
    }

    public Disciplina(string nombre, List<ISubPuntuacion> subPuntuaciones)
    {
        Nombre = nombre;
        _subPuntuaciones = subPuntuaciones;
    }
}
