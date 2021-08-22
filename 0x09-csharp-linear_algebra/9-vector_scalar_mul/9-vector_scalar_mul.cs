using System;

class VectorMath
{
    /// <summary>Multiplies two vectors</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length > 3 || vector.Length < 2)
        {
            return new double[1] { -1 };
        }
        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] *= scalar;
        }
        return vector;
    }
}
