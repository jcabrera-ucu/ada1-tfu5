namespace TFU5;

public class PuntuarTiempoDto
{
    public double Segundos { get; set; }
}

public class PuntuarDistanciaDto
{
    public double Metros { get; set; }
}

public class PuntuacionDto
{
    public PuntuarTiempoDto? Tiempo { get; set; }

    public PuntuarDistanciaDto? Distancia { get; set; }
}