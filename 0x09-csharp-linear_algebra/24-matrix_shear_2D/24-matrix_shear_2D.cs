using System;

class MatrixMath
{
    /// <summary>Shears a 2D matrix</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(1) != 2 || direction != 'x' && direction != 'y')
            return new double[1, 1] {{-1}};

        double[,] ans = (double[,])matrix.Clone();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (direction == 'x')
            {
                ans[i, 0] += matrix[i, 1] * factor;
            }
            else
            {
                ans[i, 1] += matrix[i, 0] * factor;
            }
        }
        return ans;
    }
}