using TFU5.Domain;
using TFU5.Data;

namespace TFU5.Infra;

public class AtletaMemRepository : IAtletaRepository
{
    private readonly Dictionary<Guid, Atleta> _atletas = [];

    public AtletaMemRepository()
    {
    }

    public Atleta? Get(Guid id)
    {
        if (_atletas.TryGetValue(id, out Atleta? atleta))
        {
            return atleta;
        }

        return null;
    }

    public void Save(Atleta atleta)
    {
        _atletas.Add(atleta.Id, atleta);
    }

    public List<Atleta> List()
    {
        return [.. _atletas.Values];
    }
}
