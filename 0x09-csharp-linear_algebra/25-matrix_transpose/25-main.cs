using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] M = new double[3, 2] {{1, 2}, {3, 4}, {5, 6}};
        double[,] N = new double[2, 3] {{1, 2, 3}, {4, 5, 6}};
        PrintMatrix(MatrixMath.Transpose(M));
        PrintMatrix(MatrixMath.Transpose(N));
        PrintMatrix(MatrixMath.Transpose(new double[,] {{}}));
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
