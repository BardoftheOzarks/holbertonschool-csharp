using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> scanner = myLList.First;
        if (scanner.Value > n)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }
        while (scanner.Next != null)
        {
            if (scanner.Value > n)
            {
                myLList.AddBefore(scanner, n);
                return scanner.Previous;
            }
            scanner = scanner.Next;
        }
        myLList.AddLast(n);
        return myLList.Last;
    }
}