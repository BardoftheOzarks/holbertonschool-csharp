using System;

class Program
{
    static void Main(string[] args)
    {
        double[] Vector1 = new double[1] { 5 };
        double[] Vector2 = new double[1] { 4 };
        Console.Write("Two 1D elements: (");
        foreach (var item in VectorMath.Add(Vector1, Vector2))
            Console.Write($" {item}");
        Console.Write(" )\n");
        double[] Vector3 = new double[2] { 8, -11 };
        double[] Vector4 = new double[2] { -4, 9 };
        Console.Write("Two 2D elements: (");
        foreach (var item in VectorMath.Add(Vector3, Vector4))
            Console.Write($" {item}");
        Console.Write(" )\n");
        double[] Vector5 = new double[3] { 14, -2, 0 };
        double[] Vector6 = new double[3] { -3, 23, 50 };
        Console.Write("Two 3D elements: (");
        foreach (var item in VectorMath.Add(Vector5, Vector6))
            Console.Write($" {item}");
        Console.Write(" )\n");
        double[] Vector7 = new double[4] { 5, 14, -2, 0};
        double[] Vector8 = new double[4] { 4, -3, 23, 50};
        Console.Write("Two 4D elements: (");
        foreach (var item in VectorMath.Add(Vector7, Vector8))
            Console.Write($" {item}");
        Console.Write(" )\n");
        Console.Write($"One 2D element and One 3D element: (");
        foreach (var item in VectorMath.Add(Vector4, Vector5))
            Console.Write($" {item}");
        Console.Write(" )\n");
    }
}