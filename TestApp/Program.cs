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







using Collections.Collections;

CustomLinkedList<int> list = new CustomLinkedList<int>();
list.AddFirst(0);
list.AddFirst(1);
list.AddFirst(2);
var node=list.AddFirst(3);
list.AddAfter(node,6);
foreach (var item in list)
{
    Console.WriteLine(item);
}





