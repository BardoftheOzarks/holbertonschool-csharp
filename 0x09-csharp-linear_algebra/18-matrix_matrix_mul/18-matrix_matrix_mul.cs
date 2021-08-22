using System;
using System.Collections.Generic;

class MatrixMath
{
    /// <summary>Multiplies two matrices</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[1, 1] {{-1}};

        double[,] matrix3 = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int row = 0; row < matrix3.GetLength(0); row++)
            for (int col = 0; col < matrix3.GetLength(1); col++)
            {
                matrix3[row, col] = 0;
                for (int i = 0; i < matrix1.GetLength(1); i++)
                        matrix3[row, col] += matrix1[row, i] * matrix2[i, col];
            }
        return matrix3;
    }
}
