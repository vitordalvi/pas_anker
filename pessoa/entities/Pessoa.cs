namespace pessoa.entities;

public class Pessoa
{
    public string nome { get; set; }
    public int idade { get; set; }
    public string genero { get; set; }

    public Pessoa(string nome, int idade, string genero)
    {
        this.nome = nome;
        this.idade = idade;
        this.genero = genero;
    }

    public bool ehMaior()
    {
        if (idade >= 18)
        {
            return true;
        }

        return false;
    }

    public void mostrarInformacoes()
    {
        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Genero: {genero}\nMaior de idade: {ehMaior()}");
    }
}