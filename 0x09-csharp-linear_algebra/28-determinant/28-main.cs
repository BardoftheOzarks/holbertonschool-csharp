using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] M = new double[3, 2] {{1, 2}, {3, 4}, {5, 6}};
        double[,] N = new double[2, 3] {{1, 2, 3}, {4, 5, 6}};
        double[,] O = new double[2, 2] {{2, 2}, {-9, 4}};
        double[,] P = new double[3, 3] {{-4, 9, 0}, {1, -2, 1}, {3, -4, 2}};
        Console.WriteLine(MatrixMath.Determinant(M) + "\n");
        Console.WriteLine(MatrixMath.Determinant(N) + "\n");
        Console.WriteLine(MatrixMath.Determinant(O) + "\n");
        Console.WriteLine(MatrixMath.Determinant(P) + "\n");
        Console.WriteLine(MatrixMath.Determinant(new double[,] {{}}) + "\n");
    }
}