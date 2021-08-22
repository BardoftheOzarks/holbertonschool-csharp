using System;

class MatrixMath
{
    /// <summary>Transposes a matrix of any size</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] ans = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int row = 0; row < matrix.GetLength(0); row++)
            for(int col = 0; col < matrix.GetLength(1); col++)
                ans[col, row] = matrix[row, col];
        return ans;
    }
}