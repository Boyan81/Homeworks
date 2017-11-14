using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            double baseN = double.Parse(input[0]);
            char[] number = input[1].Reverse().ToArray();
            BigInteger sum = new BigInteger();
            for (int i = 0; i < number.Length; i++)
            {
                sum += (number[i]-48) * BigInteger.Pow(new BigInteger(baseN),i);
            }
            Console.WriteLine(sum);
        }
    }
}
