using CustomLinkedList.Models;

var linkedList = new MyLinkedList();

//["MyLinkedList","addAtHead","addAtTail","addAtIndex","get","deleteAtIndex","get"]
//[[],[1],[3],[1,2],[1],[1],[1]]

linkedList.AddAtHead(1);
linkedList.AddAtTail(3);
//linkedList.AddAtIndex(1,2);
//Console.WriteLine(linkedList.Get(1));
//linkedList.DeleteAtIndex(1);
//Console.WriteLine(linkedList.Get(1));
//Console.WriteLine(linkedList.Count);

foreach (var item in linkedList)
{
    Console.Write(item + " ");
}

linkedList.Reverse();

Console.WriteLine();

foreach (var item in linkedList)
{
    Console.Write(item + " ");
}

Console.WriteLine();