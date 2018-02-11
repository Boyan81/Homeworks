using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_N_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int num = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            input.Sort();
            for (int i = input.Count-1; i >=input.Count-num; i--)
            {
                result.Add(input[i]);
            }
            Console.WriteLine(String.Join(" ",result));

        }
    }
}
