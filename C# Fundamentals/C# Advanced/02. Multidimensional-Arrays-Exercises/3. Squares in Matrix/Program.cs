using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] rowAndColum = Console.ReadLine()
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            string[,] matrix = new string[rowAndColum[0], rowAndColum[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    matrix[row, colum] = input[colum];
                }
            }
            int coun = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1) - 1; colum++)
                {
                    if (matrix[row, colum] == matrix[row, colum + 1] && matrix[row, colum] == matrix[row + 1, colum] && matrix[row, colum] == matrix[row + 1, colum + 1])
                    {
                        coun++;
                    }
                }
            }
            Console.WriteLine(coun);
        }
    }
}
