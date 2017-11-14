using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            var result = new Dictionary<string, int>();

            foreach (var item in input)
            {
                result[item] = 0;
            }
            foreach (var item in input)
            {
                result[item]++;
            }
            List<string> outResult = new List<string>();
            foreach (var item in result)
            {
                if (item.Value % 2 != 0)
                {
                    outResult.Add(item.Key);
                }

            }
            Console.WriteLine(String.Join(", ",outResult));
           
        }
    }
}
