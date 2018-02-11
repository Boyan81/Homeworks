using System;
using System.Linq;

namespace _02._Crypto_Master
{
    class Program
    {
        static void Main()
        {
            int[] number = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int max = 0;

            for (int step = 1; step < number.Length; step++)
            {
                for (int index = 0; index < number.Length; index++)
                {
                    int currentIndex = index;
                    int nexIndex = (index+step) % number.Length;
                    int currentMax = 1;

                    while (number[currentIndex]<number[nexIndex])
                    {
                        currentIndex = nexIndex;
                        nexIndex = (nexIndex + step) % number.Length;
                        currentMax++;
                    }
                    if (currentMax>max)
                    {
                        max = currentMax;
                    }

                }
            }
            Console.WriteLine(max);
        }
    }
}
