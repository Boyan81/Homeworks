using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Target_Practice
{
    class Program
    {
        public static string[,] matrix;
        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                 .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int colum = dimensions[1];
            int matrixLength = rows * colum;
            matrix = new string[rows, colum];
            string word = Console.ReadLine();
            int[] cmd = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            MatrixInput(rows, colum, matrixLength, word);
            ShortLands(cmd);
            Gravity();
            PrintMatrix();

        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void Gravity()
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int emptyRow = 0;
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    if (matrix[row,col]==" ")
                    {
                        emptyRow++;
                    }
                    else if(emptyRow > 0)
                    {
                        matrix[row + emptyRow, col] = matrix[row, col];
                        matrix[row, col] = " ";
                    }
                }
            }
        }

        private static void ShortLands(int[] cmd)
        {
            int shotRow = cmd[0];
            int shotColum = cmd[1];
            int shotRadius = cmd[2];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    int a = shotRow - r;
                    int b = shotColum - c;
                    double distans = Math.Sqrt(a * a + b * b);
                    if (distans <= shotRadius)
                    {
                        matrix[r, c] = " ";
                    }
                }
            }
        }

        private static void MatrixInput(int rows, int colum, int matrixLength, string word)
        {
            StringBuilder str = new StringBuilder();
            int lenght = matrixLength / word.Length + 1;
            for (int i = 0; i < lenght; i++)
            {
                str.Append(word);
            }
            List<char> inputWord = str.ToString().Take(matrixLength).ToList();
            int count = 0;
            for (int row = rows - 1; row >= 0; row--)
            {
                if (count % 2 == 0)
                {
                    for (int col = colum - 1; col >= 0; col--)
                    {
                        matrix[row, col] = inputWord[0].ToString();
                        inputWord.RemoveAt(0);
                    }
                    count++;
                }
                else
                {
                    for (int col = 0; col < colum; col++)
                    {
                        matrix[row, col] = inputWord[0].ToString();
                        inputWord.RemoveAt(0);
                    }

                    count++;
                }
            }
        }
    }
}
