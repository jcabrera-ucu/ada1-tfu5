namespace TFU5.Domain;

public class Categoria
{
    public Genero Genero { get; private set; }

    public CategoriaEdad Edad { get; private set; }

    public CategoriaPeso Peso { get; private set; }
}