namespace TFU5.Domain;

public class PuntuacionDistancia: ISubPuntuacion
{
    public double DistanciaM { get; set; }

    public void Accept(ISubPuntuacionVisitor visitor)
    {
        visitor.VisitDistancia(this);
    }
}