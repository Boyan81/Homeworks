using System;
using System.Linq;

namespace _01._Dangerous_Floor
{
    class Program
    {
        static char[][] board;

        static void Main(string[] args)
        {
            board = new char[8][];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Console.ReadLine().Split(',').Select(char.Parse).ToArray();
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                char figur = input[0];
                int startRow = int.Parse(input[1].ToString());
                int startCol = int.Parse(input[2].ToString());
                int targetRow = int.Parse(input[4].ToString());
                int targetCol = int.Parse(input[5].ToString());

                if (!CheckFigar(figur, startRow, startCol))
                {
                    Console.WriteLine("There is no such a piece!");
                    continue;
                }
                if (!IsMoveValid(figur, startRow, startCol, targetRow, targetCol))
                {
                    Console.WriteLine("Invalid move!");
                    continue;
                }
                if (!OutOfBoard(targetRow, targetCol))
                {
                    Console.WriteLine("Move go out of board!");
                    continue;
                }
                board[targetRow][targetCol] = board[startRow][startCol];
                board[startRow][startCol] = 'x';
            }
        }



        private static bool OutOfBoard(int targetRow, int targetCol)
        {
            bool validRow = targetRow >= 0 && targetRow <= board.Length - 1;
            bool validCol = targetCol >= 0 && targetCol <= board.Length - 1;
            return validCol && validRow;
        }
        private static bool IsMoveValid(char figur, int startRow, int startCol, int targetRow, int targetCol)
        {
            switch (figur)
            {
                case 'P':
                    return ValidPawnMove(startRow, startCol, targetRow, targetCol);
                case 'R':
                    return ValidRookMove(startRow, startCol, targetRow, targetCol);
                case 'B':
                    return DiagonalMove(startRow, startCol, targetRow, targetCol);
                case 'Q':
                    return ValidRookMove(startRow, startCol, targetRow, targetCol) ||
                        DiagonalMove(startRow, startCol, targetRow, targetCol);
                case 'K':
                    return ValidKingMove(startRow, startCol, targetRow, targetCol);
                default:
                    throw new Exception();
            }
        }

        private static bool ValidKingMove(int startRow, int startCol, int targetRow, int targetCol)
        {
            bool valitRow = Math.Abs(startRow - targetRow) == 1 || Math.Abs(startRow - targetRow) == 0;
            bool validCol = Math.Abs(startCol - targetCol) == 1 || Math.Abs(startCol - targetCol) == 0;
            return validCol && valitRow;
        }

        private static bool DiagonalMove(int startRow, int startCol, int targetRow, int targetCol)
        {

            return Math.Abs(startRow - targetRow) == Math.Abs(startCol - targetCol);
        }

        private static bool ValidRookMove(int startRow, int startCol, int targetRow, int targetCol)
        {
            return startRow == targetRow || startCol == targetCol;
        }

        private static bool ValidPawnMove(int startRow, int startCol, int targetRow, int targetCol)
        {
            return startCol == targetCol && startRow - 1 == targetRow;
        }

        private static bool CheckFigar(char figur, int startRow, int startCol)
        {
            return board[startRow][startCol] == figur;
        }
    }
}
