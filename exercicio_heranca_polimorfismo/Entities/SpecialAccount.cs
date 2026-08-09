namespace exercicio_heranca_polimorfismo.Entities;

public class SpecialAccount : BankAccount
{
    public double limit { get; private set; } // ngm deve mexer nesse atributo fora dessa classe pq as regras sao feitas aq

    // construtor da conta padrao, os atributos criados aqui vao pra super classe,
    // menos o atributo especial dessa classe
    public SpecialAccount(int accountNumber, string ownerName, double balance, double limit) : base(accountNumber, ownerName, balance)
    {
        this.limit = limit;
    }
    
    public override void withdraw(double amount)
    {
        if (amount > balance || amount < limit)
        {
            Console.WriteLine("Saldo e limite insuficientes");
            return; // o return vai ser para parar a função aqui mesmo
        }

        // se passou pela validação, usa a funcao da super classe operacao ser completa
        base.withdraw(amount);
    }
}