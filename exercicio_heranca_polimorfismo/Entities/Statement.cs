namespace exercicio_heranca_polimorfismo.Entities;

public class Statement
{
    public double currentBalance { get; set; } // saldo atual (antes da operacao ser feita)
    public double amountAdded { get; set; } // se a operacao foi deposito, vamos colocar o valor adicionado,
                                            // ai acho que podemos criar o extrato e o amount removed seria 0
    public double amountRemoved { get; set; } // saldo removido, usar no metodo de saque, mesma logica da variavel,
                                              // de saldo adicionado, ao criar o extrato no metodo vamos usar,
                                             // os valores respectivos

    public Statement() {} // construtor vazio pra gente startar com um a lista de extratos vazia + guardar valor inicial
    
    public Statement(double currentBalance, double amountAdded, double amountRemoved)
    {
        this.currentBalance = currentBalance;
        this.amountAdded = amountAdded;
        this.amountRemoved = amountRemoved;
    }
}