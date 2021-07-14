using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count > 0)
        {
            int biggest = myList[0];
            foreach (int nummer in myList)
                if (nummer > biggest)
                    biggest = nummer;
            return biggest;
        }
        Console.WriteLine("List is empty");
        return -1;
    }
}