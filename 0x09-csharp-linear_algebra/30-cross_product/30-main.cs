using System;

class Program
{
    static void Main(string[] args)
    {
        double[] V = new double[3] {2, -2, 1};
        double[] U = new double[3] {-8, 8, -4};
        double[] ans1 = VectorMath.CrossProduct(V, U);
        for (int i = 0; i < ans1.Length; i++)
            Console.Write($"{ans1[i]} ");
        Console.WriteLine();
        double[] M = new double[3] {2, 3, 4};
        double[] N = new double[3] {5, 6, 7};
        double[] ans2 = VectorMath.CrossProduct(M, N);
        for (int i = 0; i < ans2.Length; i++)
            Console.Write($"{ans2[i]} ");
        Console.WriteLine();
    }
}
