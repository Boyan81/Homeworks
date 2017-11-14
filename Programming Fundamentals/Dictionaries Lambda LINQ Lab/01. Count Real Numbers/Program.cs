using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            double[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
                

            var result = new SortedDictionary<double, int>();
            foreach (var item in input)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result[item] = 1;
                }
            }
            foreach (var item in result.Keys)
            {
                Console.WriteLine($"{item} -> {result[item]}");
            }
        }
    }
}
