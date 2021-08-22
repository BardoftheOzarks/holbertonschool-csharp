using System;

class Program
{
    static void Main(string[] args)
    {
        double[] Vector1 = new double[1] { 5 };
        double[] Vector2 = new double[1] { 4 };
        Console.WriteLine($"Two 1D elements: {VectorMath.DotProduct(Vector1, Vector2)}");
        double[] Vector3 = new double[2] { 1, 3 };
        double[] Vector4 = new double[2] { -2, 5 };
        Console.WriteLine($"Two 2D elements: {VectorMath.DotProduct(Vector3, Vector4)}");
        double[] Vector5 = new double[3] { -4, 0, 10 };
        double[] Vector6 = new double[3] { 3, 7, -9 };
        Console.WriteLine($"Two 3D elements: {VectorMath.DotProduct(Vector5, Vector6)}");
        double[] Vector7 = new double[4] { 5, 14, -2, 0};
        double[] Vector8 = new double[4] { 4, -3, 23, 50};
        Console.WriteLine($"Two 4D elements: {VectorMath.DotProduct(Vector7, Vector8)}");
        Console.WriteLine($"One 2D element and One 3D element: {VectorMath.DotProduct(Vector4, Vector5)}");
    }
}