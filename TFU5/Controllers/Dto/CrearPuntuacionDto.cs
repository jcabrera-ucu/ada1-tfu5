using TFU5.Domain;

namespace TFU5;

public class PuntuarTiempoDto
{
    public double Segundos { get; set; }
}

public class PuntuarDistanciaDto
{
    public double Metros { get; set; }
}

public class PuntuarPuntosDto
{
    public int Puntos { get; set; }
}

public class CrearPuntuacionDto
{
    public PuntuarTiempoDto? Tiempo { get; set; }

    public PuntuarDistanciaDto? Distancia { get; set; }

    public PuntuarPuntosDto? Puntos { get; set; }

    public List<ISubPuntuacion> Crear()
    {
        List<ISubPuntuacion> result = [];

        if (Tiempo != null)
        {
            result.Add(new PuntuacionTiempo(Tiempo.Segundos));
        }
        else if (Distancia != null)
        {
            result.Add(new PuntuacionDistancia(Distancia.Metros));
        }
        else if (Puntos != null)
        {
            result.Add(new PuntuacionPuntos(Puntos.Puntos));
        }

        return result;
    }
}