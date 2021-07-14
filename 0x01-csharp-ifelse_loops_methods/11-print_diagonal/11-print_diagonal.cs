using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = i; j > 0; --j)
                Console.Write(' ');
            Console.WriteLine('\\');
        }
        Console.Write('\n');
    }
}