using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Diagonal_Difference
{
    class Program
    {
        public static int[,] matrix;
        public static int leftSum;
        public static int rightSum;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];
            leftSum = 0;
            rightSum = 0;
            for (int row = 0; row < n; row++)
            {
                int[] rowOne = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int colum = 0; colum < n; colum++)
                {
                    matrix[row, colum] = rowOne[colum];

                }
            }
            LeftRezult();
            RightResult();
            Console.WriteLine(Math.Abs(leftSum - rightSum));

        }

        private static void RightResult()
        {
            int colum = matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rightSum += matrix[i, colum - 1];
                colum--;
            }

        }

        private static void LeftRezult()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    if (row == colum)
                    {
                        leftSum += matrix[row, colum];
                    }
                }
            }
        }
    }
}
