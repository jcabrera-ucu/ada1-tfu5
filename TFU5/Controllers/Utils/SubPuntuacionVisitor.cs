using TFU5.Domain;

namespace TFU5;

class SubPuntuacionVisitor : ISubPuntuacionVisitor
{
    public List<CompetenciaPuntuacionDto> Puntuaciones { get; set; } = [];

    public void VisitDistancia(PuntuacionDistancia distancia)
    {
        Puntuaciones.Add(new(PuntuacionDistancia.Identificador, distancia.DistanciaM.ToString()));
    }

    public void VisitTiempo(PuntuacionTiempo tiempo)
    {
        Puntuaciones.Add(new(PuntuacionTiempo.Identificador, tiempo.Segundos.ToString()));
    }

    public void VisitPuntos(PuntuacionPuntos puntos)
    {
        Puntuaciones.Add(new(PuntuacionPuntos.Identificador, puntos.Puntos.ToString()));
    }
}
