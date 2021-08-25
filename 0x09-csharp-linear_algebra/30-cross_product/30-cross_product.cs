using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1};
        double[] vector3 = new double[3];
        vector3[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        vector3[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        vector3[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
        return vector3;
    }
}