using conta_bancaria_dificil.entities;

class Program
{
    public static void Main(string[] args)
    {
        Cartao c1 = new Cartao("1234", "12/28");
        Cartao c2 = new Cartao("4567", "10/27");
        Cartao c3 = new Cartao("8910", "08/30");
        Conta conta1 = new Conta("vitor", 1, 1000, c1);
        Conta conta2 = new Conta("anker", 2, 500, c2);
        Conta conta3 = new Conta("chamona", 3, 2000, c3);

        conta1.depositar(500);
        conta1.sacar(200);

        conta2.depositar(100);
        conta2.sacar(50);

        conta3.sacarComCartao("3333", "08/30", 700);

        Conta[] contas = { conta1, conta2, conta3 };

        foreach (Conta conta in contas)
        {
            Console.WriteLine($"Conta: {conta.obterNumero()}");
            Console.WriteLine($"Titular: {conta.obterNomeCliente()}");
            Console.WriteLine($"Saldo: {conta.obterSaldo()}");
            conta.mostrarExtrato();
        }
    }
}