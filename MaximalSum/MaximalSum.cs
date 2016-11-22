using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Int32.Parse(input[0]);
            int m = Int32.Parse(input[1]);
            int[,] matrix = new int[n, m];
            int maxSum = int.MinValue;
            int currentSum = int.MinValue;

            for (int row = 0; row < n; row++)
            {
                string matrixInput = Console.ReadLine();
                string[] arrLine = new string[m];
                arrLine = matrixInput.Split(' ');

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(arrLine[col]);
                }
            }

            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < m - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine(maxSum);

        }
    }
}
