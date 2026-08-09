using circulo.entities;

class Program
{
    public static void Main(string[] args)
    {
        Circulo circulo = new Circulo(10);
        circulo.raio = 30;
        circulo.mostrarInformacoes();
        
        TestCirculo();
    }

    private static void TestCirculo()
    {
        Circulo testCirculo = new Circulo(5);
        Console.WriteLine("Testando Circulo:");
        Console.WriteLine($"Raio: {testCirculo.raio}");
        Console.WriteLine($"Área: {testCirculo.calcularArea(testCirculo.raio)}");
        Console.WriteLine($"Perímetro: {testCirculo.calcularPerimetro(testCirculo.raio)}");
    }
}
