using System;

class MatrixMath
{
    /// <summary>Finds the determinant for any matrix</summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
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
            return sum;
        }
        double ans = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        return ans;
    }
}
