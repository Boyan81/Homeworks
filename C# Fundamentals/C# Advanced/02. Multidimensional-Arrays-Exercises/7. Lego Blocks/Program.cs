using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Lego_Blocks
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] first = ReadJanggerArray(n);
            int[][] second = ReadJanggerArray(n);
            ReversSecondArr(second);
            List<List<int>> result = new List<List<int>>();
            result.Add(new List<int>());
            result[0].AddRange(first[0].ToList());
            result[0].AddRange(second[0].ToList());
            int lenght = result[0].Count; ;
            int count = 1;
            for (int i = 1; i < first.Length; i++)
            {
                result.Add(new List<int>());
                result[i].AddRange(first[i]);
                result[i].AddRange(second[i]);
                int tempLenght = result[i].Count;
                if (lenght==tempLenght)
                {
                    count++;
                }
            }
            if (count==n)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine($"[{String.Join(", ",result[i])}]");
                }
            }
            else
            {
                int sumCount = 0;
                for (int i = 0; i < result.Count; i++)
                {
                    sumCount += result[i].Count;
                }
                Console.WriteLine($"The total number of cells is: {sumCount}");
            }
           
        }

        private static void ReversSecondArr(int[][] second)
        {
            for (int i = 0; i < second.Length; i++)
            {
                Array.Reverse(second[i]);
            }
        }

        private static int[][] ReadJanggerArray(int n)
        {
            int[][] jaggedArray = new int[n][];
            for (int r = 0; r < n; r++)
            {
                jaggedArray[r] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            return jaggedArray;
        }
    }
}
