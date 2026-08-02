namespace livro.entities;

public class Livro
{
    public string titulo { get; set; }
    public string autor { get; set; }
    public int anoPublicacao { get; set; }
    public int numeroPaginas { get; set; }
    
    public bool disponivel { get; set; } // coloquei esse atributo aq pra gnt ter como saber se ta disponivel ou nao né
                                        // acho que faltou no enunciado, bom, espero

    public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas, bool disponivel)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anoPublicacao = anoPublicacao;
        this.numeroPaginas = numeroPaginas;
        this.disponivel = disponivel;
    }

    public void emprestar()
    {
        if (disponivel)
        {
            disponivel = false;
            Console.WriteLine("Livro emprestado");
        }
        else
        {
            Console.WriteLine("o livro ja esta emprestado");
        }
    }

    public void devolver()
    {
        if (!disponivel)
        {
            disponivel = true;
            Console.WriteLine("livro devolvido");
        }
        
        Console.WriteLine("o livro ja esta disponivel");
    }

    public bool isDisponivel()
    {
        return disponivel;
    }
}