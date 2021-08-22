using System;
using System.Collections.Generic;

class MatrixMath
{
    /// <summary>Rotates a 2D matrix by an angle in radians</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(1) != 2)
            return new double[1, 1] {{1}};
        
        double[,] ans = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            ans[row, 0] = Math.Round((matrix[row, 0] * Math.Cos(angle)) - (matrix[row, 1] * Math.Sin(angle)), 2);
            ans[row, 1] = Math.Round((matrix[row, 0] * Math.Sin(angle)) + (matrix[row, 1] * Math.Cos(angle)), 2);
        }
        return ans;
    }
}
