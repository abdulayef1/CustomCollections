using Collections.Nodes;
using System.Collections;

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
            Last = newNode;
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
    
    
    
    public CustomLinkedNodes<T> AddLast(T value)
    {
        CustomLinkedNodes<T> newNode = new(value);
        if (Last is null)
        {
            First = newNode;
            Last = newNode;
            Last.Previous = null;
            Last.Next = null;
        }
        else
        {
            var prev = Last;
            Last = newNode;
            Last.Previous = prev;
            prev.Next = Last;
            Last.Next = null;
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
