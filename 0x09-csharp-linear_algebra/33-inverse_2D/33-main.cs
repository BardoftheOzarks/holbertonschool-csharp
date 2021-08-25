using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] M = new double[2, 2] {{1, 2}, {3, 4}};
        PrintMatrix(MatrixMath.Inverse2D(M));
        double[,] N = new double[2, 2] {{4, 7}, {2, 6}};
        PrintMatrix(MatrixMath.Inverse2D(N));
    }
    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
                if (j != matrix.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
