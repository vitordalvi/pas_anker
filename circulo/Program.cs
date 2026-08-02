using circulo.entities;

class Program
{
    public static void Main(string[] args)
    {
        Circulo circulo = new Circulo(10);
        circulo.raio = 30;
        circulo.mostrarInformacoes();
    }
}