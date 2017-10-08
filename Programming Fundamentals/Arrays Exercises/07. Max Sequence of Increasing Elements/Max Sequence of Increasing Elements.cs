using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            int lent = 0;

            int bestLen = 0;
            int bestStart = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] < arr[i + 1])
                {
                    lent++;

                    if (lent > bestLen)
                    {
                        bestLen = lent;
                        bestStart = i - lent;
                    }
                }
                else
                {
                    lent = 0;
                }

            }
            for (int i = bestStart + 1; i <= bestLen + bestStart + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
