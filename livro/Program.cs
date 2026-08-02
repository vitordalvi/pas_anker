using livro.entities;

class Program
{
    public static void Main(string[] args)
    {
        Livro livro = new Livro("a historia da facul ucl", "chamon", 2026, 1, true);
        livro.emprestar();
        livro.isDisponivel();
        livro.devolver();
        livro.isDisponivel();
    }
}