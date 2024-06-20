namespace TFU5.Domain;

public class PuntuacionTiempo: ISubPuntuacion
{
    public double Segundos { get; set; }

    public static string Identificador { get; } = "tiempo";

    public PuntuacionTiempo()
    {
    }

    public PuntuacionTiempo(double segundos)
    {
        Segundos = segundos;
    }

    public void Accept(ISubPuntuacionVisitor visitor)
    {
        visitor.VisitTiempo(this);
    }

    public DescSubPuntuacion Descripcion()
    {
        return new DescSubPuntuacion(Identificador, Unidad.Segundos);
    }

    public ISubPuntuacion Clone()
    {
        return new PuntuacionTiempo(Segundos);
    }
}