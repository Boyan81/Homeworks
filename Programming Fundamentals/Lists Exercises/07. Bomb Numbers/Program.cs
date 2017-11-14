using System;
using System.Collections.Generic;
using System.Linq;


namespace Substing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bumb = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] == bumb[0])
                {

                    int right = Math.Min((number.Count - 1), (bumb[1] + i));
                    int left = Math.Max(i - bumb[1], 0);
                    int leght = right - left + 1;
                    number.RemoveRange(left, leght);
                    i = 0;
                }
            }
            long sum = 0;
            for (int i = 0; i < number.Count; i++)
            {
                sum += number[i];
            }


            Console.WriteLine(sum);
        }
    }
}