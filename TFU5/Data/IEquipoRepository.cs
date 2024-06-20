using TFU5.Domain;

namespace TFU5.Data;


public interface IEquipoRepository
{
    public Equipo? Get(Guid id);

    public void Save(Equipo equipo);

    public List<Equipo> List();
}