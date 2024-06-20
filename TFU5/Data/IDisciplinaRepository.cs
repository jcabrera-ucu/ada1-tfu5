using TFU5.Domain;

namespace TFU5.Data;


public interface IDisciplinaRepository
{
    public Disciplina? Get(string nombre);

    public void Save(Disciplina disciplina);

    public List<Disciplina> List();
}