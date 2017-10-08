using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main()
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

                if (arr[i] == arr[i+1])
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
            for (int i = bestStart+1; i <= bestLen+bestStart+1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
