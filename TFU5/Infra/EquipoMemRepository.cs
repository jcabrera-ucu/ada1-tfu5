using TFU5.Domain;
using TFU5.Data;

namespace TFU5.Infra;

public class EquipoMemRepository : IEquipoRepository
{
    private readonly Dictionary<Guid, Equipo> _equipos = [];

    public EquipoMemRepository()
    {
    }

    public Equipo? Get(Guid id)
    {
        if (_equipos.TryGetValue(id, out Equipo? equipo))
        {
            return equipo;
        }

        return null;
    }

    public void Save(Equipo equipo)
    {
        _equipos[equipo.Id] = equipo;
    }

    public List<Equipo> List()
    {
        return [.. _equipos.Values];
    }
}
