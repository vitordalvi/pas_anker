namespace exercicio_heranca_polimorfismo.Entities;

public class DefaultAccount : BankAccount
{
    // construtor da conta padrao, os atributos criados aqui vao pra super classe
    public DefaultAccount(int accountNumber, string ownerName, double balance) : base(accountNumber, ownerName, balance)
    {
    }

    public override void withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Saldo insuficiente");
            return; // o return vai ser para parar a função aqui mesmo
        }

        // se passou pela validação, usa a funcao da super classe operacao ser completa
        base.withdraw(amount);
    }
}