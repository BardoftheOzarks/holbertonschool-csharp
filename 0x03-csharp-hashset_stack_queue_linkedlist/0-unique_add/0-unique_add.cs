using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueList = new HashSet<int>();
        foreach (int num in myList)
            uniqueList.Add(num);
        int sum = 0;
        foreach (int num in uniqueList)
            sum = sum + num;
        return sum;
    }
}