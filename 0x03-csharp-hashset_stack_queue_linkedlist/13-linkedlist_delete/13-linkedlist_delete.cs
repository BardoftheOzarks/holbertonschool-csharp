using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> scanner = myLList.First;
        for (int i = 0; i < index; i++)
            scanner = scanner.Next;
        myLList.Remove(scanner);
    }
}