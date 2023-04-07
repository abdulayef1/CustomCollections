using Collections.Nodes;
using System.Collections;

namespace Collections.Collections;

public class CustomLinkedList<T> : IEnumerable<T>
{

    public CustomLinkedNodes<T>? First { get; set; }
    public CustomLinkedNodes<T>? Last { get; set; }
    public int Count { get; private set; }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public IEnumerator<T> GetEnumerator()
    {
        CustomLinkedNodes<T>? temp = First;
        while (temp != null)
        {
            yield return temp.Value;
            temp = temp.Next;
        }
    }
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
    public CustomLinkedNodes<T> Find(T value)
    {
        CustomLinkedNodes<T>? temp = First;
        while (temp != null)
        {
            if (temp.Value.Equals(value))
            {
                return temp;
            }
            temp = temp.Next;
        }
        return default;

    }
    public CustomLinkedNodes<T> AddAfter(CustomLinkedNodes<T> after, T value)
    {
        var node = Find(after.Value);
        if (node != null)
        {
            var next = node.Next;
            if (next is null)
            {
                return AddLast(value);
            }
            CustomLinkedNodes<T> newNode = new(value);
            next.Previous = newNode;
            node.Next = newNode;
            newNode.Previous = node;
            newNode.Next = next;
            Count++;
            return newNode;
        }
        return default;

    }
    public CustomLinkedNodes<T> AddBefore(CustomLinkedNodes<T> before, T value)
    {
        var node = Find(before.Value);
        if (node != null)
        {
            var previous = node.Previous;
            if (previous is null)
            {
                return AddFirst(value);
            }
            Count++;
            CustomLinkedNodes<T> newNode = new(value);
            newNode.Previous = previous;
            previous.Next = newNode;
            previous = newNode;
            newNode.Next = node;
            return newNode;
        }
        return default;

    }
    public bool Remove(T value)
    {
        var node = Find(value);
        if (node is null) return false;
        var next = node.Next;
        var prev = node.Previous;
        if (next is null) 
        {
            RemoveLast();
            return true;
        }
        if (prev is null) 
        {
            RemoveFirst();
            return true;
        }
        next.Previous = prev;
        prev.Next = next;
        Count--;
        return true;
    }
    public void Remove(CustomLinkedNodes<T> node)
    {
        Remove(node.Value);
    }
    public void RemoveFirst()
    {
        First = First.Next;
        First.Previous = null;
        Count--;
    }
    public void RemoveLast()
    {
        Last = Last.Previous;
        Last.Next = null;
        Count--;
    }
    
    

}
