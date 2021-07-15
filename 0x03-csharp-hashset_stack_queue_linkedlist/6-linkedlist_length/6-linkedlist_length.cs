using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myList)
    {
        int sum = 0;
        foreach (var element in myList)
            sum++;
        return sum;
    }
}