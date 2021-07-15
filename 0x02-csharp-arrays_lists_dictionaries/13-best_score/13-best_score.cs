using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList != null)
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
            return name;
        }
        return "None";
    }
}