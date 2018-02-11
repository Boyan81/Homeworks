using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Crossfire
{
    class Program
    {
        public static List<List<int>> matrix;
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int colums = dimentions[1];
            matrix = new List<List<int>>();
            
            int n = 1;
            for (int row = 0; row < rows; row++)
            {
                matrix.Add(new List<int>());
                for (int col = 0; col < colums; col++)
                {
                    matrix[row].Add(n++);
                }
            }
            string input = Console.ReadLine();
            while (input!= "Nuke it from orbit")
            {
                int[] cmd = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();
                int cmdRow = cmd[0];
                int cmdColum = cmd[1];
                int cmdRadius = cmd[2];
                RemovedElements(cmdRow, cmdColum, cmdRadius);
                input = Console.ReadLine();
            }

        }

        private static void RemovedElements(int cmdRow, int cmdColum, int cmdRadius)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Count; col++)
                {

                }
            }
        }
    }
}
