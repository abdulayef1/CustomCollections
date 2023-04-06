
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
list.AddLast(3);
var node=list.AddLast(9);
list.AddLast(5);

Console.WriteLine("Numbers:");

list.AddAfter(node,13);

foreach (var item in list)
{
    Console.Write($" {item} ");
}
//[1,3,5,9,13]
//Console.WriteLine();
//Console.WriteLine("----------------------------");







