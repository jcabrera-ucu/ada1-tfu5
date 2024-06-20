using TFU5.Domain;

namespace TFU5;

public class CrearAtletaDto
{
    public required string Nombre { get; set; }

    public required string Apellido { get; set; }

    public required List<string> Disciplinas { get; set; }
}