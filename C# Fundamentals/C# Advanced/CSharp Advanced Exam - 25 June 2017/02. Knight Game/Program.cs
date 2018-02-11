using System;
using System.Collections.Generic;

namespace _02._Knight_Game
{
    class Program
    {
        static void Main()
        {
            int rowAndCoulm = int.Parse(Console.ReadLine());
            string[,] table = new string[rowAndCoulm, rowAndCoulm];
            for (int row = 0; row < table.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < table.GetLength(1); col++)
                {
                    
                    table[row, col] = input[col].ToString();
                }
            }
            int maxAtac = 0;
            int maxRow = 0;
            int maxCoulm = 0;
            int countOutKnight = 0;

            do
            {
                if (maxAtac>0)
                {
                    table[maxRow, maxCoulm] = "0";
                    maxAtac = 0;
                    countOutKnight++;
                }


                int currentAtack = 0;
                for (int row = 0; row < table.GetLength(0); row++)
                {
                    for (int col = 0; col < table.GetLength(1); col++)
                    {
                        
                        if (table[row,col]=="K")
                        {
                            currentAtack = CalculateAtackPositon(row,col,table);
                            if (currentAtack>maxAtac)
                            {
                            maxAtac = currentAtack;
                            maxRow = row;
                            maxCoulm = col; 
                            }
                        }
                    }
                }

            } while (maxAtac>0);

            Console.WriteLine(countOutKnight);
        }

         static int CalculateAtackPositon(int row, int coul, string[,] table)
        {
            var currentAtack = 0;
            if (IsAtackt(row - 2, coul - 1, table)) currentAtack++;
            if (IsAtackt(row - 2, coul + 1, table)) currentAtack++;
            if (IsAtackt(row - 1, coul - 2, table)) currentAtack++;
            if (IsAtackt(row - 1, coul + 2, table)) currentAtack++;
            if (IsAtackt(row + 1, coul - 2, table)) currentAtack++;
            if (IsAtackt(row + 1, coul + 2, table)) currentAtack++;
            if (IsAtackt(row + 2, coul - 1, table)) currentAtack++;
            if (IsAtackt(row + 2, coul + 1, table)) currentAtack++;
            return currentAtack;
        }
        static bool IsAtackt(int row,int coulom,string[,] table)
        {
            return IsPosOnTable(row, coulom, table.GetLength(0)) &&
                table[row, coulom] == "K";
        }
        static bool IsPosOnTable(int row,int coulm,int size)
        {
            return row >= 0 && row < size && coulm >= 0 && coulm < size;
        }
    }
}
