namespace TFU5.Domain;

public class PuntuacionPuntos: ISubPuntuacion
{
    public int Puntos { get; set; }

    public static string Identificador { get; } = "puntos";

    public PuntuacionPuntos()
    {
    }

    public PuntuacionPuntos(int puntos)
    {
        Puntos = puntos;
    }

    public void Accept(ISubPuntuacionVisitor visitor)
    {
        visitor.VisitPuntos(this);
    }

    public DescSubPuntuacion Descripcion()
    {
        return new DescSubPuntuacion(Identificador, Unidad.Puntos);
    }

    public ISubPuntuacion Clone()
    {
        return new PuntuacionPuntos(Puntos);
    }
}