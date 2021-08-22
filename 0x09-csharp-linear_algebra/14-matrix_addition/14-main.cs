using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] M = new double[3, 3] {{14, -3, 0}, {-11, -5, 3}, {2, -9, 13}};
        double[,] N = new double[3, 3] {{6, 16, 21}, {5, 2, 0}, {1, 3, 7}};
        PrintMatrix(MatrixMath.Add(M, N));
        double[,] O = new double[2, 2] {{14, -3}, {-11, -5}};
        double[,] P = new double[2, 2] {{6, 16}, {5, 2}};
        PrintMatrix(MatrixMath.Add(O, P));
        PrintMatrix(MatrixMath.Add(N, O));
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