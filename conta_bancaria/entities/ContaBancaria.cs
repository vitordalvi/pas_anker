namespace conta_bancaria.entities;

public class ContaBancaria
{
    public string numeroConta { get; set; }
    public string nomeTitular { get; set; }
    public double saldo { get; set; }

    public ContaBancaria(string numeroConta, string nomeTitular, double saldo)
    {
        this.numeroConta = numeroConta;
        this.nomeTitular = nomeTitular;
        this.saldo = saldo;
    }

    public void depostiar(double valor)
    {
        saldo += valor;
    }

    public void sacar(double valor)
    {
        saldo -= valor;
    }

    public void exibirSaldo()
    {
        Console.WriteLine($"Saldo: {saldo}");
    }
}