LinkedList<int> list=new LinkedList<int>();
list.AddFirst(0);
list.AddFirst(1);
list.AddFirst(2);
list.AddFirst(3);
list.AddLast(4);
list.Clear();
foreach (var item in list)
{
    Console.WriteLine(item);
}