using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null && array.Length > 0)
        {
            for (int i = array.Length - 1; i > 0; i--)
                Console.Write("{0} ", array[i]);
            Console.Write(array[0]);
        }
        Console.Write('\n');
    }
}