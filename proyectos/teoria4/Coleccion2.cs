namespace Teoria4;
class Coleccion2 {
    private readonly List<string?> lista= new List<string?>();
    public void Agregar(string? obj)
    {
        lista.Add(obj);
    }
    public void Imprimir() {
        foreach ( object? n in lista ) 
            Console.WriteLine($"Lista: {n}");
    }
}