using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size >= 0)
        {
            int[] NewArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                NewArray[i] = i;
                if (i == size -1)
                    Console.Write(i);
                else
                    Console.Write("{0} ", i);
            }
            Console.Write('\n');
            return NewArray;
        }
        else
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
    }
}