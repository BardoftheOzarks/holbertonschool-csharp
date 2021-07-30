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
            int width = matrix.GetLength(0);
            int length = matrix.GetLength(1);
            var answers = new int[width, length];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; i < length; j++)
                {
                    answers[i, j] = matrix[i, j] / num;
                }
            }
            return answers;
        }
    }
}
