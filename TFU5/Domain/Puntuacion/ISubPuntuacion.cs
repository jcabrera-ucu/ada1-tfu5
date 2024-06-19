namespace TFU5.Domain;

public interface ISubPuntuacion
{
    void Accept(ISubPuntuacionVisitor visitor);

    DescSubPuntuacion Descripcion();

    ISubPuntuacion Clone();
}
