using Collections.Nodes;
using System.Collections;
using System.Security.Authentication;

namespace Collections.Collections;

public class CustomLinkedList<T> : IEnumerable<T>
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
            First.Previous = null;
        }
        Count++;
        return newNode;
    }

    public IEnumerator<T> GetEnumerator()
    {
        CustomLinkedNodes<T>? temp = First;
        while (temp!=null)
        {
            yield return temp.Value;
            temp= temp.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
