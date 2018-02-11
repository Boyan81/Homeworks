using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<string, bool> filter = NameLessOrEaqul(n);

            names = names.Where(filter).ToList();
            names.ForEach(x => Console.WriteLine(x));
        }

        private static Func<string, bool> NameLessOrEaqul(int n)
        {
            return nam =>
            {
                if (nam.Length<=n)
                {
                    return true;
                }
                return false;
            };

        }
    }
}
