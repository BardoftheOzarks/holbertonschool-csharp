using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] M = new double[2, 2] {{1, 2}, {3, 4}};
        double[,] N = new double[2, 3] {{1, 2, 3}, {4, 5, 6}};
        PrintMatrix(MatrixMath.Shear2D(M, 'x', 2));
        PrintMatrix(MatrixMath.Shear2D(M, 'y', 2));
        PrintMatrix(MatrixMath.Shear2D(M, 'z', 2));
        PrintMatrix(MatrixMath.Shear2D(N, 'x', 2));
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
