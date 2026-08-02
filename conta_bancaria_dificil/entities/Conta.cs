namespace conta_bancaria_dificil.entities;
public class Conta
{
    public string nomeCliente { get; set; }
    public int numeroConta { get; set; }
    public double saldo { get; set; }

    public Extrato[] extratos { get; set; } = new Extrato[1000];
    private int posicao = 0;

    public Cartao cartao { get; set; }

    public Conta(string nomeCliente, int numeroConta, double saldo, Cartao cartao)
    {
        this.nomeCliente = nomeCliente;
        this.numeroConta = numeroConta;
        this.saldo = saldo;
        this.cartao = cartao;
    }

    public void depositar(double valor)
    {
        saldo += valor;

        extratos[posicao] = new Extrato(DateTime.Now, valor);
        posicao++;

        Console.WriteLine("deposito realizado");
    }

    public void sacar(double valor)
    {
        if (saldo >= valor)
        {
            saldo -= valor;

            extratos[posicao] = new Extrato(DateTime.Now, -valor);
            posicao++;

            Console.WriteLine("saque realizado");
        }
        else
        {
            Console.WriteLine("saldo insuficiente");
        }
    }

    public double obterSaldo()
    {
        return saldo;
    }

    public int obterNumero()
    {
        return numeroConta;
    }

    public string obterNomeCliente()
    {
        return nomeCliente;
    }

    public void mostrarExtrato()
    {
        Console.WriteLine("Extrato:");

        for (int i = 0; i < posicao; i++)
        {
            Console.WriteLine($"{extratos[i].data} - {extratos[i].valor}");
        }
    }

    public void sacarComCartao(string numero, string validade, double valor)
    {
        if (cartao.numero == numero && cartao.validade == validade)
        {
            sacar(valor);
        }
        else
        {
            Console.WriteLine("cartao invalido");
        }
    }
}