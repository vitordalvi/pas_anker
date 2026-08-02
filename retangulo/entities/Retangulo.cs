namespace retangulo.entities;

public class Retangulo
{
    public double largura { get; set; }
    public double altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        this.largura = largura;
        this.altura = altura;
    }

    public double calcularArea(double largura, double altura)
    {
        return  largura * altura;
    }

    public double calcularPerimetro(double largura, double altura)
    {
        return 2 * (largura + altura);
    }

    public void exibirInformacoes()
    {
        Console.WriteLine($"Largura: {largura}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Área: {calcularArea(largura, altura)}");
        Console.WriteLine($"Perímetro: {calcularPerimetro(largura, altura)}");
    }
}