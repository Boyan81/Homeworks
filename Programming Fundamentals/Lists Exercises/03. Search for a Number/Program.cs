using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int[] comand = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var temp = input.Take(comand[0]).ToList();
            temp.RemoveRange(0, comand[1]);
            if (temp.Contains(comand[2].ToString()))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
                
        }
    }
}
