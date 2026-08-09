using exercicio_heranca_polimorfismo.DataStructures;

namespace exercicio_heranca_polimorfismo.Entities;

public abstract class BankAccount
{
    public int accountNumber { get; set; } // numero da conta
    public string ownerName { get; set; } // nome do titular
    public double balance { get; set; } // saldo
    public DList<Statement> accountStatement { get; set; } // extratos ok!

    public BankAccount(int accountNumber,  string ownerName, double balance)
    {
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        this.balance = balance;
        accountStatement = new DList<Statement>();
    }

    public void deposit(double amount)
    {
        balance += amount;
        
        // cria o objeto do extrato
        Statement statement = new Statement(
            balance, // saldo atual da conta
            amount, // valor depositado
            0); // valor removido (0 porque é o metodo de deposito)
        
        accountStatement.addEnd(statement); // adiciona o extrato no final da lista de extratos da conta
    }
    
    public virtual void withdraw(double amount)
    {
        double currentBalance = balance;

        balance -= amount;
        
        Statement statement = new Statement(currentBalance, 0, amount); // (saldo atual, adicionado, valor)
        accountStatement.addEnd(statement); // adiciona o extrato na lista de extratos da conta
    }
}