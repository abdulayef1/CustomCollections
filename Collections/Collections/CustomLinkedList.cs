using Collections.Nodes;
using System.Security.Authentication;

namespace Collections.Collections;

public class CustomLinkedList<T>
{

    public CustomLinkedNodes<T>? First { get; set; }
    public CustomLinkedNodes<T>? Last { get; set; }
    public int Count { get; private set; }
    public CustomLinkedList()
    {
        Count = 0;
    }
    public CustomLinkedNodes<T> AddFirst(T value)
    {
        CustomLinkedNodes<T> newNode = new(value);
        if (First is null)
        {
            First = newNode;
            First.Previous = null;
            First.Next = null;
        }
        else
        {
            var next = First;
            First = newNode;
            First.Next = next;
            next.Previous = First;
            next.Next = null;
            First.Previous = null;
        }

        return newNode;
    }



}
