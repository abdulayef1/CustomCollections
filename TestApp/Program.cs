
using Collections.Collections;
//LinkedList<int> list = new LinkedList<int>();
//list.AddFirst(2);
//list.AddFirst(4);
//6 12 4 2
//var node=list.Find(12);
//list.AddAfter(,);
//Console.WriteLine(node is null); ;

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}







CustomLinkedList<int> list = new CustomLinkedList<int>();
list.AddLast(1);
list.AddFirst(29);
list.AddLast(3);
var node=list.AddLast(9);
list.AddLast(5);
list.AddFirst(29);
list.AddLast(37);
list.AddLast(7);

Console.WriteLine("Numbers:");

var addedNnode=list.AddAfter(node,13);
var addedNnode1=list.AddAfter(addedNnode, 14);
list.AddBefore(addedNnode1, 99);
var addedNnode2=list.AddAfter(addedNnode1, 16);
list.AddBefore(addedNnode, 151);
list.AddAfter(addedNnode2, 23);

//Console.WriteLine(list.Last.Next.Value);

//Console.WriteLine(list.Count);
//![13,1,3,5,9]

foreach (var item in list)
{
    Console.Write($" {item} ");
}
Console.WriteLine();
Console.WriteLine("----------------------------");







