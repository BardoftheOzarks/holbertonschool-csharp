using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
            }
            if (num == 0 || matrix == null)
                return null;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            var answers = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    answers[i, j] = matrix[i, j] / num;
                }
            }
            return answers;
        }
    }
}
