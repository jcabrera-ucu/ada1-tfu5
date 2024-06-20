using TFU5.Domain;

namespace TFU5;

public class DisciplinaDto(IDisciplina disciplina)
{
    public string Nombre { get; set; } = disciplina.Nombre;

    public List<DescSubPuntuacion> SubPuntuaciones { get; set; } = disciplina.SubPuntuaciones
            .Select(x => x.Descripcion())
            .ToList();
}