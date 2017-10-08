using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main()
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (num.Length!=1)
            {
                int[] condensed = new int[num.Length - 1];
                for (int i = 0; i < num.Length - 1; i++)
                {
                    condensed[i] = num[i] + num[i + 1];
                }
                num = condensed;
            }
            Console.WriteLine(num[0]);

        }
    }
}
