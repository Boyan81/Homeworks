using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Square_With_Maximum_Sum
{
    class Program
    {
        static void Main()
        {
            int[] rowAndCound = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[rowAndCound[0], rowAndCound[1]];
            
            for (int row = 0; row < rowAndCound[0]; row++)
            {
                int[] inputCoum = Console.ReadLine()
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int coulm = 0; coulm < rowAndCound[1]; coulm++)
                {
                    matrix[row, coulm] = inputCoum[coulm];
                }
            }

            int maxSum = 0;
            int indexRow = 0;
            int indexColum = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1)-1; colum++)
                {
                    int tempSum = matrix[row, colum] + matrix[row, colum + 1] +
                        matrix[row + 1, colum] + matrix[row + 1, colum + 1];
                    if (tempSum>maxSum)
                    {
                        maxSum = tempSum;
                        indexRow = row;
                        indexColum = colum;
                    }
                }
            }
            Console.WriteLine(matrix[indexRow,indexColum]+" "+matrix[indexRow,indexColum+1]);
            Console.WriteLine(matrix[indexRow+1,indexColum]+" "+matrix[indexRow+1,indexColum+1]);
            Console.WriteLine(maxSum);

        }
    }
}
