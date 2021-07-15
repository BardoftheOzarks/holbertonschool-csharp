using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var Array = new int [5, 5];
            Array[2, 2] = 1;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (j == 4)
                        Console.Write("{0}\n", Array[i, j]);
                    else
                        Console.Write("{0} ", Array[i, j]);
        }
    }
}
