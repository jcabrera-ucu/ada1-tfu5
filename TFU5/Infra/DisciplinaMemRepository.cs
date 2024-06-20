using TFU5.Domain;
using TFU5.Data;

namespace TFU5.Infra;

public class DisciplinaMemRepository : IDisciplinaRepository
{
    private readonly Dictionary<string, Disciplina> _disciplinas = [];

    public DisciplinaMemRepository()
    {
    }

    public Disciplina? Get(string nombre)
    {
        if (_disciplinas.TryGetValue(nombre, out Disciplina? disciplina))
        {
            return disciplina;
        }

        return null;
    }

    public void Save(Disciplina disciplina)
    {
        _disciplinas[disciplina.Nombre] = disciplina;
    }

    public List<Disciplina> List()
    {
        return [.. _disciplinas.Values];
    }
}
