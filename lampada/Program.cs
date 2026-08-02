using lampada.entities;

class Program
{
    public static void Main(string[] args)
    {
        Lampada lampada = new Lampada(10, 10);
        
        lampada.mostrarInformacoes();
        lampada.ligar();
        lampada.mostrarInformacoes();
        lampada.desligar();
        lampada.mostrarInformacoes();
    }
}