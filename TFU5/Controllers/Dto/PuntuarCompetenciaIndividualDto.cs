namespace TFU5;


public class PuntuarCompetenciaIndividualDto
{
    public Guid IdCompetencia { get; set; }

    public Guid IdJuez { get; set; }

    public Guid IdAtleta { get; set; }
    
    public List<CrearPuntuacionDto> Puntuaciones { get; set; } = [];
}