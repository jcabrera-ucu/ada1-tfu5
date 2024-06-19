using System.Text.Json;


namespace TFU5.Domain;

public class DescripcionPuntuacionDistancia
{
    public string Identificador { get; set; } = "distancia";

    public string Unidad { get; set; } = "m";
}

public class PuntuacionDistancia: ISubPuntuacion
{
    public double DistanciaM { get; set; }

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
        return new DescSubPuntuacion("PuntuacionDistancia", Unidad.Metros);
    }

    public ISubPuntuacion Clone()
    {
        return new PuntuacionDistancia(DistanciaM);
    }
}