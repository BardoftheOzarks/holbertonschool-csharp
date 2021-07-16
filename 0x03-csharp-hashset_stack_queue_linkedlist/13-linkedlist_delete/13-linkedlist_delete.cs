using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList.Count > index)
        {
            LinkedListNode<int> scanner = myLList.First;
            for (int i = 0; i < index; i++)
                if (scanner.Next != null)
                    scanner = scanner.Next;
                else
                    return;
            myLList.Remove(scanner);
        }
    }
}