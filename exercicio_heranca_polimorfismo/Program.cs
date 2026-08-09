using exercicio_heranca_polimorfismo.Entities;

class Program
{
    public static void Main(string[] args)
    {
        SpecialAccount specialAccount = new SpecialAccount(1, "vitor", 200, 500);
        specialAccount.withdraw(400);

        DefaultAccount defaultAccount = new DefaultAccount(2, "vitor2", 1000);
        defaultAccount.withdraw(500);
        defaultAccount.withdraw(5);
        
        specialAccount.deposit(500);
        specialAccount.withdraw(500);
        
        defaultAccount.deposit(500);
        defaultAccount.withdraw(500);
    }
}


