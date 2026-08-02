namespace circulo.entities;

public class Circulo
{
    public double raio { get; set; }

    public Circulo(double raio)
    {
        this.raio = raio;
    }
    
    public double calcularArea(double raio)
    {
        return 3.14 * (raio * raio);
    }

    public double calcularPerimetro(double raio)
    {
        return 2 * 3.14 * raio;
    }

    public void mostrarInformacoes()
    {
        Console.WriteLine($"Raio: {raio}\n" +
                          $"Área: {calcularArea(raio)}\n" +
                          $"Perimetro: {calcularPerimetro(raio)}");
    }
}