namespace TFU5.Domain;


public interface IPuntuacion
{
    public ICompetencia Competencia { get; }

    public List<ISubPuntuacion> SubPuntuaciones { get; }

    public void Add(ISubPuntuacion sub_puntuacion);
}
