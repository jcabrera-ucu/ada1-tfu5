namespace TFU5.Domain;

public class Categoria(Genero genero, CategoriaEdad edad, CategoriaPeso peso)
{
    public Genero Genero { get; private set; } = genero;

    public CategoriaEdad Edad { get; private set; } = edad;

    public CategoriaPeso Peso { get; private set; } = peso;
}