using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            BigInteger baseN = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            string result = string.Empty;
            BigInteger remainder;

            while (number>0)
            {
            remainder = number % baseN;
            number = number / baseN;
            result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
