using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Maximal_Sum
{
    class Program
    {
        public static int[,] matrix;
        static void Main()
        {
            int[] rowAndColum = Console.ReadLine()
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            matrix = new int[rowAndColum[0], rowAndColum[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    matrix[row, colum] = input[colum];
                }
            }
            int maxSum = int.MinValue;
            int indexRow = 0;
            int indexColum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1) - 2; colum++)
                {
                    int temp = SumMidleMatrix(row, colum);
                    if (temp > maxSum)
                    {
                        maxSum = temp;
                        indexRow = row;
                        indexColum = colum;
                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            PrintMatrix(indexRow, indexColum);
        }

        private static void PrintMatrix(int indexRow, int indexColum)
        {

            for (int r = indexRow; r < indexRow + 3; r++)
            {
                for (int c = indexColum; c < indexColum + 3; c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int SumMidleMatrix(int row, int colum)
        {
            int sum = 0;
            for (int r = row; r < row + 3; r++)
            {
                for (int c = colum; c < colum + 3; c++)
                {
                    sum += matrix[r, c];
                }
            }
            return sum;
        }
    }
    
}
