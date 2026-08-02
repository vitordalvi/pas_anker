using retangulo.entities;

class Program
{
    public static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo(10, 10);

        retangulo.calcularArea(retangulo.largura, retangulo.altura);
        retangulo.calcularPerimetro(retangulo.largura, retangulo.altura);
        retangulo.exibirInformacoes();
    }
}