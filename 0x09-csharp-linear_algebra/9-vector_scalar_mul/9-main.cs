using System;

class Program
{
    static void Main(string[] args)
    {
        double[] Vector1 = new double[1] { 5 };
        double Scalar1 = 0.5;
        Console.Write("1D element: (");
        foreach (var item in VectorMath.Multiply(Vector1, Scalar1))
            Console.Write($" {item}");
        Console.Write(" )\n");
        double[] Vector2 = new double[2] { 98, 972 };
        Console.Write("2D element: (");
        foreach (var item in VectorMath.Multiply(Vector2, Scalar1))
            Console.Write($" {item}");
        Console.Write(" )\n");
        double[] Vector3 = new double[3] { 0, -16, -31 };
        double Scalar2 = 4;
        Console.Write("3D element: (");
        foreach (var item in VectorMath.Multiply(Vector3, Scalar2))
            Console.Write($" {item}");
        Console.Write(" )\n");
        double[] Vector4 = new double[4] { 5, -7, 3, 9 };
        Console.Write("4D element: (");
        foreach (var item in VectorMath.Multiply(Vector4, Scalar2))
            Console.Write($" {item}");
        Console.Write(" )\n");
    }
}