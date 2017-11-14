using System;
using System.Collections.Generic;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            Console.WriteLine(fac);
        }
        
    }
}
