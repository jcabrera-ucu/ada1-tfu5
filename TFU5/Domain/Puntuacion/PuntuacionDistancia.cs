using System.Text.Json;


namespace TFU5.Domain;

public class PuntuacionDistancia: ISubPuntuacion
{
    public double DistanciaM { get; set; }

    public static string Identificador { get; } = "distancia";

    public PuntuacionDistancia()
    {
        DistanciaM = 0;
    }

    public PuntuacionDistancia(double distancia)
    {
        DistanciaM = distancia;
    }

    public void Accept(ISubPuntuacionVisitor visitor)
    {
        visitor.VisitDistancia(this);
    }

    public DescSubPuntuacion Descripcion()
    {
        return new DescSubPuntuacion(Identificador, Unidad.Metros);
    }

    public ISubPuntuacion Clone()
    {
        return new PuntuacionDistancia(DistanciaM);
    }
}