namespace conta_bancaria_dificil.entities;

public class Extrato
{
    public DateTime data { get; set; }
    public double valor { get; set; }

    public Extrato(DateTime data, double valor)
    {
        this.data = data;
        this.valor = valor;
    }
}