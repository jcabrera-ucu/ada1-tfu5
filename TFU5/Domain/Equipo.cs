namespace TFU5.Domain;

public class Equipo
{
    public List<Atleta> Atletas { get; set; } = [];

    public bool PerteneceAtleta(Atleta atleta)
    {
        return Atletas.Find(x => x.Id == atleta.Id) != null;
    }
}