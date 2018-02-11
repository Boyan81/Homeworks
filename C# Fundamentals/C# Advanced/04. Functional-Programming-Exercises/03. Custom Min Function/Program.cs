using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main()
        {
            var number = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToArray();

            Func<int[], int> functionMin = MinVaule;
            int result = functionMin(number);
            Console.WriteLine(result);
        }
        static int MinVaule(int[] number)
        {
            int min = int.MaxValue;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]<min)
                {
                    min = number[i];
                }
            }
            return min;
        }
    }
}
