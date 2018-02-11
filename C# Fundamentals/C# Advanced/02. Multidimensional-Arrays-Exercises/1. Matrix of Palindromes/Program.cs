using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Matrix_of_Palindromes
{
    class Program
    {
        private static string[,] matrix;
        static void Main()
        {
            int[] dimentionMatrix = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = dimentionMatrix[0];
            int columns = dimentionMatrix[1];
            matrix = new string[rows, columns];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int row = 0; row < rows; row++)
            {
                for (int colum = 0; colum < columns; colum++)
                {
                    string temp;

                    temp = alphabet[row].ToString() + alphabet[row + colum].ToString() + alphabet[row].ToString();

                    matrix[row, colum] = temp;
                }
            }
            Print();
        }

        private static void Print()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    Console.Write(matrix[row, colum] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
