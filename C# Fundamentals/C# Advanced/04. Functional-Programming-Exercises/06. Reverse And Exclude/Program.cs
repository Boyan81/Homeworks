using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            int num = int.Parse(Console.ReadLine());

            numbers.Reverse();
            Func<int, bool> function = n => n % num != 0;
            numbers = numbers.Where(function).ToList();

            Console.WriteLine(String.Join(" ",numbers));
        }

        
    }
}
