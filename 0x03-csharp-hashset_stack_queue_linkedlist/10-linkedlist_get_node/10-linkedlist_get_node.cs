using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n >= 0 && n < myLList.Count)
        {
            LinkedListNode<int> scanner = myLList.First;
            for (int i = 0; i < n; i++)
                scanner = scanner.Next;
            return scanner.Value;
        }
        return 0;
    }
}