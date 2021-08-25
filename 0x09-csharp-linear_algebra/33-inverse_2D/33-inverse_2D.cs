using System;

class MatrixMath
{
    /// <summary>Determines the inverse of a 2D array</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2
        || Determinant(matrix) == 0)
            return new double[1, 1] {{-1}};
        double factor = (1 / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0])));
        double[,] ans = new double[2, 2];
        ans[0, 0] = Math.Round(matrix[1, 1] * factor, 2);
        ans[0, 1] = Math.Round(matrix[0, 1] * factor * -1, 2);
        ans[1, 0] = Math.Round(matrix[1, 0] * factor * -1, 2);
        ans[1, 1] = Math.Round(matrix[0, 0] * factor, 2);
        return ans;
    }
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) > 3)
            return -1;
        
        if (matrix.GetLength(0) > 2)
        {
            double sum = 0;
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                double[,] smaller = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
                double factor = matrix[0, a];
                if (a % 2 == 1)
                    factor *= -1;
                for (int b = 0; b < matrix.GetLength(0) - 1; b++)
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        if (c == a)
                            continue;
                        else if (c > a)
                            smaller[b, c - 1] = matrix[b + 1, c];
                        else
                            smaller[b, c] = matrix[b + 1, c];
                    }
                sum += factor * Determinant(smaller);
            }
            return Math.Round(sum, 2);
        }
        double ans = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        return Math.Round(ans, 2);
    }
}