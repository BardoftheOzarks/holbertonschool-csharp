using System;

class VectorMath
{
    /// <summary>Adds two vectors</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length > 3 || vector1.Length < 2)
        {
            return new double[1] { -1 };
        }
        double[] vector3 = new double[vector1.Length];
        vector3[0] = vector1[0] + vector2[0];
        vector3[1] = vector1[1] + vector2[1];
        if (vector1.Length > 2)
        {
            vector3[2] = vector1[2] + vector2[2];
        }
        return vector3;
    }
}
