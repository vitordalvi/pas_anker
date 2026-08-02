using conta_bancaria.entities;

class Program 
{
    public static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria("1", "Vitor", 300);

        conta.exibirSaldo();
        
        conta.depostiar(100);
        conta.exibirSaldo();
        
        conta.sacar(400);
        conta.exibirSaldo();
    }
}