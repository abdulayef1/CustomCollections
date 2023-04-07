LinkedList<int> list = new LinkedList<int>();
list.AddFirst(2);
list.AddFirst(4);
list.AddFirst(4);
list.AddFirst(5);
list.AddFirst(7);
list.AddFirst(12);
list.AddFirst(6);
list.AddFirst(4);
list.AddFirst(4);
list.AddFirst(4);
list.AddFirst(2);
list.AddFirst(4);
var node = list.AddFirst(1);
list.AddFirst(4);
list.AddFirst(3);
list.AddFirst(4);
list.Clear();
Console.WriteLine(node.Next.Value);


foreach (var item in list)
{
    Console.Write($" {item} ");
}
Console.WriteLine();
Console.WriteLine("----------------------------");


