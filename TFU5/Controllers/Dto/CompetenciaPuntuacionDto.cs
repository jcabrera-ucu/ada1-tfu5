namespace TFU5;


public class CompetenciaPuntuacionDto(string id, string valor)
{
    public string Identificador { get; set; } = id;

    public string Valor { get; set; } = valor;
}