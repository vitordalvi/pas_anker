using System.ComponentModel;

namespace exercicio_heranca_polimorfismo.DataStructures;

public class DList<T>
{
    public Node<T>? head { get; private set; }
    public Node<T>? tail { get; private set; }
    public int size { get; private set; }
    
    public DList()
    {
        head = null;
        tail = null;
        size = 0;
    }

    public bool isEmpty()
    {
        if (head != null)
        {
            return false;
        }

        return true;
    }

    public void addStart(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (isEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            Node<T> currentHead = head;
            newNode.next = currentHead;
            currentHead.prev = newNode;
            head = newNode;
        }

        size++;
    }

    public void addEnd(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (isEmpty())
        {
            addStart(value);
            return;
        }

        Node<T> currentTail = tail;
        currentTail.next = newNode;
        newNode.prev = currentTail;
        tail = newNode;
        
        size++;
    }

    public Node<T> find(T value)
    {
        Node<T> current = head;

        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.value, value))
            {
                return current;
            }

            current = current.next;
        }

        return null;
    }

    public void clear()
    {
        head = null;
        tail = null;
        size = 0;
    }
}