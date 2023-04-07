using Collections.Collections;

CustomLinkedList<int> list = new CustomLinkedList<int>();
list.AddFirst(1);
list.AddFirst(2);
list.AddFirst(3);



foreach (var item in list)
{
    Console.Write($" {item} ");
}



