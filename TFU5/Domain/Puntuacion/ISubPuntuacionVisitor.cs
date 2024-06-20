namespace TFU5.Domain;


public interface ISubPuntuacionVisitor
{
    public void VisitTiempo(PuntuacionTiempo tiempo);

    public void VisitDistancia(PuntuacionDistancia distancia);

    public void VisitPuntos(PuntuacionPuntos puntos);
}
