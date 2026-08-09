namespace exercicio_heranca_polimorfismo.DataStructures;

public class Node<T>
{
    public Node<T>? prev { get; set; }
    public Node<T>? next { get; set; }
    public T value { get; private set; } // so deve ser possivel alterar o valor nessa classe

    public Node(T value)
    {
        this.value = value;
    }
}