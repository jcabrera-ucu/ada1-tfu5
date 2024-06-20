namespace TFU5;


public class PuntuarCompetenciaEquipoDto
{
    public Guid IdCompetencia { get; set; }

    public Guid IdJuez { get; set; }

    public Guid IdEquipo { get; set; }
    
    public List<CrearPuntuacionDto> Puntuaciones { get; set; } = [];
}