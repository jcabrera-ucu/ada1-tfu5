namespace TFU5.Domain;

public class DescSubPuntuacion
{
    public string Identificador { get; set; }

    public Unidad Unidad { get; set; }

    public DescSubPuntuacion(string ident, Unidad unidad)
    {
        Identificador = ident;
        Unidad = unidad;
    }
}