using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> sortedDict = new SortedList<string, string>();
        foreach (KeyValuePair<string, string> pair in myDict)
            sortedDict[pair.Key] = pair.Value;
        foreach (KeyValuePair<string, string> pair in sortedDict)
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
    }
}