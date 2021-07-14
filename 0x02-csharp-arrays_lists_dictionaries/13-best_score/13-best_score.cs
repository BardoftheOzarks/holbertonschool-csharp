﻿using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int best = 0;
        string name = "";
        foreach(KeyValuePair<string, int> pair in myList)
        {
            if (best <= pair.Value)
            {
                best = pair.Value;
                name = pair.Key;
            }
        }
        if (name == "")
            return " ";
        return name;
    }
}