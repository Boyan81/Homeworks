using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Radioactive_Bunnies
{
    class Program
    {
        public static string[,] matrix;
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int colums = dimentions[1];
            matrix = new string[rows, colums];
            int[] positionPlayer = InitialLair(rows, colums);
            string[] comand = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();

            for (int i = 0; i < comand.Length; i++)
            {
                int oldRowPlayer = positionPlayer[0];
                int oldColPlayer = positionPlayer[1];
                switch (comand[i])
                {
                    case "U":
                        positionPlayer[0]--;
                        break;
                    case "D":
                        positionPlayer[0]++;
                        break;
                    case "L":
                        positionPlayer[1]--;
                        break;
                    case "R":
                        positionPlayer[1]++;
                        break;
                }
                SpreadBunnies(rows - 1, colums - 1);

                if (positionPlayer[0]<0 || positionPlayer[0]>=rows||
                    positionPlayer[1]<0|| positionPlayer[1]>=colums)
                {
                    PrintResult(oldRowPlayer, oldColPlayer, "won");
                    return;
                }
                if (matrix[positionPlayer[0],positionPlayer[1]] =="B")
                {
                    PrintResult(positionPlayer[0], positionPlayer[1], "dead");
                    return;
                }

            }

        }

        private static void PrintResult(int rowPlayer, int colPlayer, string v)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{v}: {rowPlayer} {colPlayer}");
        }

        private static void SpreadBunnies(int r, int c)
        {
            var tempMatrix = new string[r+1, c+1];
            for (int ro = 0; ro <= r; ro++)
            {
                for (int co = 0; co <=c ; co++)
                {
                    tempMatrix[ro, co] = matrix[ro, co];
                }
            }
            for (int row = 0; row <= r; row++)
            {
                for (int col = 0; col <= c; col++)
                {
                    if (matrix[row, col] == "B")
                    {
                        if (row>0)
                        {
                            tempMatrix[row - 1, col] = "B";
                        }
                        if (row<r)
                        {
                            tempMatrix[row + 1, col] = "B";
                        }
                        if (col>0)
                        {
                            tempMatrix[row, col - 1] = "B";
                        }
                        if (col<c)
                        {
                            tempMatrix[row, col + 1] = "B";
                        }
                    }
                }
            }
            matrix = tempMatrix;
        }

        private static int[] InitialLair(int rows, int colums)
        {
            int[] positionPlayer = new int[2];
            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < colums; col++)
                {
                    matrix[row, col] = input[col].ToString();
                    if (matrix[row, col] == "P")
                    {
                        positionPlayer[0] = row;
                        positionPlayer[1] = col;
                        matrix[row, col] = ".";
                    }
                }

            }
            return positionPlayer;
        }
    }
}
