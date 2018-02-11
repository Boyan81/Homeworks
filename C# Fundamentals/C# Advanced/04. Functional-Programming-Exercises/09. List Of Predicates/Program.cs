using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                numbers.Add(i);
            }
            List<int> dividers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Func<int, bool> predicate = CreatePredicate(dividers);

            numbers = numbers.Where(predicate).ToList();

            Console.WriteLine(String.Join(" ",numbers));
        }

        private static Func<int, bool> CreatePredicate(List<int> dividers)
        {
            return num =>
            {
                foreach (var div in dividers)
                {
                    if (num % div != 0)
                    {
                        return false;
                    }
                }
                return true;
            };
        }
    }
}
