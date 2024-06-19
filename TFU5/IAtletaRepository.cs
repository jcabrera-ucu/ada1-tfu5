namespace TFU5;


public interface IAtletaRepository
{
    public Atleta? Get(Guid id);

    public void Save(Atleta atleta);
}