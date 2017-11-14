using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> num = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var result = num.OrderByDescending(x => x);
            var outResult = result.Take(3);
            Console.WriteLine(String.Join(" ",outResult));
        }
    }
}
