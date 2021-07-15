using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Array = new int[3][];
            Array[0] = new int[] {0, 1, 2, 3};
            Array[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
            Array[2] = new int[] {0, 1};
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < Array[i].Length; j++)
                    if (j == Array[i].Length - 1)
                        Console.Write("{0}\n", Array[i][j]);
                    else
                        Console.Write("{0} ", Array[i][j]);
        }
    }
}
