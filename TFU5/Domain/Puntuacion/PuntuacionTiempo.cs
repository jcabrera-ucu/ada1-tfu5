namespace TFU5.Domain;

public class PuntuacionTiempo: ISubPuntuacion
{
    public double Segundos { get; set; }

    public void Accept(ISubPuntuacionVisitor visitor)
    {
        visitor.VisitTiempo(this);
    }
}