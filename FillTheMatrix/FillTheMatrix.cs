using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char choice = char.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int counter = 1;

            switch (choice)
            {
                #region case 'a'
                case 'a':
                    for (int col = 0; col < arr.GetLength(1); col++)
                    {
                        for (int row = 0; row < arr.GetLength(0); row++)
                        {
                            arr[row, col] = counter++;
                        }
                    }
                    break;
                #endregion

                #region case 'b'
                case 'b':
                    for (int col = 0; col < arr.GetLength(1); col++)
                    {
                        if (col % 2 == 0)
                        {
                            for (int row = 0; row < arr.GetLength(0); row++)
                            {
                                arr[row, col] = counter++;
                            }
                        }
                        else
                        {
                            for (int row = arr.GetLength(0) - 1; row >= 0; row--)
                            {
                                arr[row, col] = counter++;
                            }
                        }
                    }
                    break;
                #endregion

                #region case 'c'
                case 'c':

                    for (int ro = n - 1; ro >= 0; ro--)
                    {
                        int row = ro;
                        int col = 0;
                        while (row < n && col < n)
                        {
                            arr[row, col] = counter++;
                            row++;
                            col++;
                        }
                    }

                    for (int rx = 1; rx < n; rx++)
                    {
                        int row = 0;
                        int col = rx;
                        while (row < n && col < n)
                        {
                            arr[row, col] = counter++;
                            row++;
                            col++;
                        }
                    }
                    break;
                #endregion

                #region case 'd'
                case 'd':
                    int cube = n;
                    int r = 0;
                    int c = 0;
                    while (cube > 0)
                    {
                        for (int i = 0; i < cube; i++)
                        {
                            arr[r, c] = counter++;
                            r++;
                        }
                        r--;
                        c++;
                        for (int i = 0; i < cube - 1; i++)
                        {
                            arr[r, c] = counter++;
                            c++;
                        }
                        c--;
                        r--;
                        for (int i = 0; i < cube - 1; i++)
                        {
                            arr[r, c] = counter++;
                            r--;
                        }
                        r++;
                        c--;
                        for (int i = 0; i < cube - 2; i++)
                        {
                            arr[r, c] = counter++;
                            c--;
                        }
                        r++;
                        c++;

                        cube -= 2;
                    }
                    break;
                #endregion


                default:
                    break;
            }

            // Print the result
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.Write("{0}", arr[r, c]);
                    if (c != arr.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
