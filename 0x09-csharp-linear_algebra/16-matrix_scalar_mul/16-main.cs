using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] M = new double[3, 3] {{-13, 10, 8}, {2, 0, 14}, {-4, -5, 2}};
        ///double X = new double 4;
        PrintMatrix(MatrixMath.MultiplyScalar(M, 4));
        double[,] N = new double[2, 2] {{-13, 10}, {2, 0}};
        PrintMatrix(MatrixMath.MultiplyScalar(N, 4));
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}