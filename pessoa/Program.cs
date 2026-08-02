using pessoa.entities;

class Program
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Vitor", 20, "Masculino");
        pessoa.mostrarInformacoes();
    }
}