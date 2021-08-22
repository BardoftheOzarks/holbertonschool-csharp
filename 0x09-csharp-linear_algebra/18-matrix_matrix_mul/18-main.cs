using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] M = new double[2, 3] {{1, 2, 3}, {4, 5, 6}};
        double[,] N = new double[3, 2] {{7, 8}, {9, 10}, {11, 12}};
        double[,] O = new double[2, 2] {{2, 3}, {-1, 0}};
        double[,] P = new double[2, 2] {{1, 7}, {-8, -2}};
        PrintMatrix(MatrixMath.Multiply(O, P));
        PrintMatrix(MatrixMath.Multiply(M, N));
        PrintMatrix(MatrixMath.Multiply(M, P));
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