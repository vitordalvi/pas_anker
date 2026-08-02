namespace conta_bancaria_dificil.entities;

public class Cartao
{
    public string numero { get; set; }
    public string validade { get; set; }

    public Cartao(string numero, string validade)
    {
        this.numero = numero;
        this.validade = validade;
    }
}