using System;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {

        static int longestSequence = int.MinValue;
        static int longestDiagonalSequence = int.MinValue;
        static int currentSequence = 0;
        static string currentValue = null;
        static string[,] myMatrix;

        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            char[] separators = new char[1];
            separators[0] = ' ';
            string[] stringSize = size.Split(separators);
            int n = int.Parse(stringSize[0]);
            int m = int.Parse(stringSize[1]);
            myMatrix = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] myMatrixValues = input.Split(separators);
                for (int j = 0; j < m; j++)
                {
                    myMatrix[i, j] = myMatrixValues[j];
                }
            }
            for (int j = 0; j < myMatrix.GetLength(0); j++)
            {
                for (int k = 0; k < myMatrix.GetLength(1); k++)
                {
                    if (myMatrix[j, k] != "0")
                    {
                        currentValue = myMatrix[j, k];
                        longestSequence = CheckMatrixStraightRecursively(j, k);
                        longestDiagonalSequence = CheckMatrixDiagonalsRecursively(j, k);
                    }
                }
            }
            if (longestSequence > longestDiagonalSequence)
            {
                Console.WriteLine(longestSequence);
            }
            else
            {
                Console.WriteLine(longestDiagonalSequence);
            }
        }
        static int CheckMatrixStraightRecursively(int startRow, int startCol)
        {
            if (startRow < 0 || startCol < 0 || (startRow == myMatrix.GetLength(0)) || (startCol == myMatrix.GetLength(1)) || myMatrix[startRow, startCol] == "0" || myMatrix[startRow, startCol] != currentValue)
            {
                return longestSequence;
            }

            else if (currentValue == myMatrix[startRow, startCol])
            {
                currentSequence++;
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                }
                string actualValue = myMatrix[startRow, startCol];
                myMatrix[startRow, startCol] = "0";
                CheckMatrixStraightRecursively(startRow, startCol + 1);
                CheckMatrixStraightRecursively(startRow, startCol - 1);
                CheckMatrixStraightRecursively(startRow + 1, startCol);
                CheckMatrixStraightRecursively(startRow - 1, startCol);
                currentSequence = 0;
                myMatrix[startRow, startCol] = actualValue;
            }
            return longestSequence;
        }
        static int CheckMatrixDiagonalsRecursively(int startRow, int startCol)
        {
            if (startRow < 0 || startCol < 0 || (startRow == myMatrix.GetLength(0)) || (startCol == myMatrix.GetLength(1)) || myMatrix[startRow, startCol] == "0" || myMatrix[startRow, startCol] != currentValue)
            {
                return longestSequence;
            }

            else if (currentValue == myMatrix[startRow, startCol])
            {
                currentSequence++;
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                }
                string actualValue = myMatrix[startRow, startCol];
                myMatrix[startRow, startCol] = "0";
                CheckMatrixDiagonalsRecursively(startRow + 1, startCol + 1);
                CheckMatrixDiagonalsRecursively(startRow + 1, startCol - 1);
                CheckMatrixDiagonalsRecursively(startRow - 1, startCol + 1);
                CheckMatrixDiagonalsRecursively(startRow - 1, startCol - 1);

            }
            currentSequence = 0;
            return longestSequence;

        }
    }
}
