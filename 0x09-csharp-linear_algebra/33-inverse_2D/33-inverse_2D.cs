using System;

class MatrixMath
{
    /// <summary>Determines the inverse of a 2D array</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[1, 1] {{-1}};
        double factor = (1 / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0])));
        double[,] ans = new double[2, 2];
        ans[0, 0] = Math.Round(matrix[1, 1] * factor, 2);
        ans[0, 1] = Math.Round(matrix[0, 1] * factor * -1, 2);
        ans[1, 0] = Math.Round(matrix[1, 0] * factor * -1, 2);
        ans[1, 1] = Math.Round(matrix[0, 0] * factor, 2);
        return ans;
    }
}