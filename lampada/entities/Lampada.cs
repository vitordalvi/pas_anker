namespace lampada.entities;

public class Lampada
{
    private bool status { get; set; } //privado pra nois so alterar aqui na classe o status da lampada
    public double potencia { get; set; }
    public double voltagem { get; set; }
    public bool queimada { get; set; }

    public Lampada(double potencia, double voltagem)
    {
        this.potencia = potencia;
        this.voltagem = voltagem;
    }

    public void ligar()
    {
        Random random = new Random();
        int chance = random.Next(0, 100);

        Console.WriteLine("Chance: " + chance);

        if (queimada)
        {
            Console.WriteLine("a lampada está queimada");
            return; // sai do metodo e printa na tela 
        }
        
        if (chance <= 15)
        {
            Console.WriteLine($"demos azar e a luz queimou, a chance disso acontecer era: {chance}");
            status = false;
            queimada = true;
        }
        else
        {
            status = true;
        }
    }

    public void desligar()
    {
        status = false;
    }

    public void mostrarInformacoes()
    {
        Console.WriteLine($"Status: {status}\n" +
                          $"Potencia: {potencia}\n" +
                          $"Voltagem:  {voltagem}\n" +
                          $"Queimada: {queimada}\n");
    }
}