using System;

class Program
{
    static void Main(string[] args)
    {
        double[] Vector1 = new double[1] { 5 };
        Console.WriteLine($"1D element: {VectorMath.Magnitude(Vector1)}");
        double[] Vector2 = new double[2] { 3, 9 };
        Console.WriteLine($"2D element: {VectorMath.Magnitude(Vector2)}");
        double[] Vector3 = new double[3] { 7, -3, -9 };
        Console.WriteLine($"3D element: {VectorMath.Magnitude(Vector3)}");
        double[] Vector4 = new double[4] { 5, -7, 3, 9 };
        Console.WriteLine($"4D element: {VectorMath.Magnitude(Vector4)}");
    }
}