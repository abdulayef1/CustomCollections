
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

var node=list.AddLast(9);
list.AddLast(1);
list.AddLast(3);
list.AddLast(5);

Console.WriteLine("Numbers:");

list.AddBefore(node,13);
var test = list.Find(13);
Console.WriteLine(test.Value);
//![13,1,3,5,9]

//foreach (var item in list)
//{
//    Console.Write($" {item} ");
//}
//Console.WriteLine();
//Console.WriteLine("----------------------------");







