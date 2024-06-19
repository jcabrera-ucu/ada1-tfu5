using TFU5.Domain;

namespace TFU5.Data;


public interface IAtletaRepository
{
    public Atleta? Get(Guid id);

    public void Save(Atleta atleta);

    public List<Atleta> List();
}