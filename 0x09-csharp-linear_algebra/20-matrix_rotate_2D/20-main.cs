using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] O = new double[2, 2] {{1, 2}, {3, 4}};
        double[,] P = new double[2, 1] {{7}, {-2}};
        PrintMatrix(MatrixMath.Rotate2D(O, -1.57));
        PrintMatrix(MatrixMath.Rotate2D(O, -.5 * Math.PI));
        PrintMatrix(MatrixMath.Rotate2D(O, Math.PI));
        PrintMatrix(MatrixMath.Rotate2D(P, -1.57));
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