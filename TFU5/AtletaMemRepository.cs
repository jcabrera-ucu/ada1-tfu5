using System.Collections.Generic;

using TFU5;

namespace TFU5;

public class AtletaMemRepository : IAtletaRepository
{
    private readonly Dictionary<Guid, Atleta> _atletas = [];

    AtletaMemRepository()
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
}
