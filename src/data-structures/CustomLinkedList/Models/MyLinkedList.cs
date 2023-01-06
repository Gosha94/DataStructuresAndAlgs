using System.Collections;

namespace CustomLinkedList.Models;

public class MyLinkedList
{

    private ListItem _head = null;
    private ListItem _tail = null;

    private int _count = 0;

    public int Count => _count;

    /// <summary>
    /// !!! Drop Later
    /// </summary>
    /// <returns></returns>
    public ListItem GetHead()
    {
        return _head;
    }

    /// <summary>
    /// Change later for return Index of Middle
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public static ListItem GetLinkedListMiddle(ListItem head)
    {
        ListItem middlePointer = head;
        ListItem currentPointer = head;

        while (currentPointer != null && currentPointer.Next != null)
        {
            middlePointer = middlePointer.Next;
            currentPointer = currentPointer.Next.Next;
        }

        return middlePointer;
    }

    /// <summary>
    /// Get the value of the index th node in the linked list
    /// </summary>
    /// <param name="index"></param>
    /// <returns>If the index is invalid, returns -1</returns>
    public int Get(int index)
    {

        if (index > _count || index < 0 || _head == null)
        {
            return -1;
        }

        var currentNode = _head;
        var currentIndex = 0;

        while (currentNode != null)
        {
            if (currentIndex == index)
            {
                return currentNode.Data;
            }
            currentNode = currentNode.Next;
            currentIndex++;
        }

        return -1;

    }

    /// <summary>
    /// Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list
    /// </summary>
    /// <param name="value"></param>
    public void AddAtHead(int value)
    {

        var newNode = new ListItem(value);

        newNode.Next = _head;

        _head = newNode;
        _count++;
    }

    /// <summary>
    /// Append a node of value val as the last element of the linked list
    /// </summary>
    /// <param name="value"></param>
    public void AddAtTail(int value)
    {
        if (_head == null)
        {
            AddAtHead(value);
            _tail = _head;
        }
        else
        {
            _tail = _head;
            
            while (_tail.Next != null)
            {
                _tail = _tail.Next;
            }

            var newNode = new ListItem(value);
            newNode.Next = null;
            
            ListItem previousNodePointer = null;

            previousNodePointer = _tail;
            previousNodePointer.Next = newNode;
            _tail = newNode;
        }
        _count++;
    }

    /// <summary>
    /// Add a node of value val before the indexth node in the linked list.
    /// If index equals the length of the linked list, the node will be appended to the end of the linked list.
    /// If index is greater than the length, the node will not be inserted.
    /// </summary>
    /// <param name="index"></param>
    /// <param name="value"></param>
    public void AddAtIndex(int index, int value)
    {

        // 1. allocate node to new element
        var newNode = new ListItem(value);
        newNode.Data = value;
        newNode.Next = null;

        // 2. check if the index is > 0
        if (index < 0)
        {
            throw new ArgumentException("\nindex should be > 0");
        }
        else if (index == 0)
        {

            //3. if the position is 1, make next of the
            //   new node as head and new node as head
            newNode.Next = _head;
            _head = newNode;
        }
        else
        {

            //4. Else, make a temp node and traverse to the 
            //   node previous to the position
            var temp = new ListItem();
            temp = _head;
            for (int i = 0; i < index - 1; i++)
            {
                if (temp != null)
                {
                    temp = temp.Next;
                }
            }

            //5. If the previous node is not null, make 
            //   newNode next as temp next and temp next 
            //   as newNode.
            if (temp != null)
            {
                newNode.Next = temp.Next;
                temp.Next = newNode;
                _count++;
            }
            else
            {
                //6. When the previous node is null
                Console.Write("\nThe previous node is null.");
            }

        }
    }

    /// <summary>
    /// Delete the indexth node in the linked list, if the index is valid
    /// </summary>
    /// <param name="position">Index of deleter item</param>
    public void DeleteAtIndex(int index)
    {

        // Для удаления ноды из списка нам нужно выполнить 2 шага
        // Найти prev и next ноды у текущей
        // Переназначить ссылку поля next у ноды prev на поле prev у ноды next, как бы обойти удаляемое значение

        // Сложность удаления по времени O(N), где N-длина связного списка т.к. нам необходимо найти ноду в поле prev, чтобы переназначить ее ссылку в обход ноды current, для этого будем идти по каждой ноде списка
        // Сложность по памяти на удаление O(1), т.к. нам нужно только место для хранения указателей, вся работа происходит с ними

        // Тактика с удалением head немного отличается
        // Нужно удалить ссылку в ноде next в поле Previous

        if (_head == null || index < 0 || index > Count - 1)
        {
            return;
        }

        var currentNode = _head;

        if (index == 0)
        {
            _head = currentNode.Next;
            return;
        }

        // Find previous node by (i < position - 1)
        for (int i = 0; currentNode != null && i < index - 1; i++)
        {
            currentNode = currentNode.Next;
        }

        if (currentNode == null)
        {
            return;
        }

        var newNextNode = currentNode.Next.Next;
        currentNode.Next = newNextNode;
        _count--;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
        _count = 0;
    }

    public IEnumerator GetEnumerator()
    {
        var current = _head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

}