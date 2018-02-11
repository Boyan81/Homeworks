using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rubiks_Matrix
{
    class Program
    {
        private static int[,] matrix;
        private static int rowsDim;
        private static int columDim;

        static void Main()
        {
            int[] dimention = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse).ToArray();
            rowsDim = dimention[0];
            columDim = dimention[1];

            matrix = new int[rowsDim, columDim];

            int number = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    matrix[row, colum] = number;
                    number++;
                }
            }
            int countCommant = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCommant; i++)
            {
                ParseComand();
            }
            RearrangeMatrix();
        }

        private static void RearrangeMatrix()
        {
            int expecket = 1;
            for (int row = 0; row < rowsDim; row++)
            {
                for (int col = 0; col < columDim; col++)
                {
                    if (matrix[row, col] == expecket)
                    {
                        Console.WriteLine("No swap required");
                        continue;
                    }
                    for (int r = row; r < rowsDim; r++)
                    {
                        for (int c = 0; c < columDim; c++)
                        {
                            if (matrix[r,c]==expecket)
                            {
                                int temp = matrix[row, col];
                                matrix[row, col] = matrix[r, c];
                                matrix[r, c] = temp;
                                Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                break;
                            }
                        }
                    }
                    expecket++;
                }
            }
        }

        private static void ParseComand()
        {
            string[] comands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string cmd = comands[1];
            int index = int.Parse(comands[0]);
            int rotation = int.Parse(comands[2]);

            switch (cmd)
            {
                case "up":
                    MoveColum(index, rowsDim - rotation);
                    break;
                case "down":
                    MoveColum(index, rotation);
                    break;
                case "left":
                    MoveRow(index, columDim - rotation);
                    break;
                case "right":
                    MoveRow(index, rotation);
                    break;
            }
        }

        private static void MoveRow(int index, int rotations)
        {
            rotations %= columDim;
            int[] tempArrey = new int[columDim];
            for (int col = 0; col < columDim; col++)
            {
                int replaceIndex = col + rotations;
                replaceIndex %= columDim;
                tempArrey[replaceIndex] = matrix[index, col];
            }
            for (int col = 0; col < columDim; col++)
            {
                matrix[index, col] = tempArrey[col];
            }
        }

        private static void MoveColum(int index, int rotations)
        {
            rotations %= rowsDim;
            int[] tempArrey = new int[rowsDim];
            for (int row = 0; row < rowsDim; row++)
            {
                int replaceIndex = row + rotations;
                replaceIndex %= rowsDim;
                tempArrey[replaceIndex] = matrix[index, row];
            }
            for (int row = 0; row < rowsDim; row++)
            {
                matrix[row, index] = tempArrey[row];
            }
        }
    }
}
