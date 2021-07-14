﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= 0 && myList.Count > index)
            myList.Remove(myList[index]);
        else
            Console.WriteLine("Index is out of range");
        return myList;
    }
}