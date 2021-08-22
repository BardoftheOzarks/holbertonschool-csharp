using System;
using System.Collections.Generic;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }
        double ans = vector[0] * vector[0];
        ans += vector[1] * vector[1];
        if (vector.Length == 3)
        {
            ans += vector[2] * vector[2];
        }
        return Math.Round(Math.Sqrt(ans), 2);
    }
}
