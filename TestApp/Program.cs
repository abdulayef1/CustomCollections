
using Collections.Collections;
using System.ComponentModel;
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
list.AddLast(2);
list.AddLast(3);
list.AddLast(4);
var node=list.AddLast(5);
list.Remove(node);


foreach (var item in list)
{
    Console.Write($" {item} ");
}
Console.WriteLine();
Console.WriteLine("----------------------------");



//LinkedList<int> list2 = new LinkedList<int>();
//list2.AddLast(1);
//list2.AddLast(2);
//list2.AddLast(3);
//list2.AddLast(4);

//Console.WriteLine(list2.Remove(12));













//? TASK:CUSTOM REMOVE METHOD










