using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _03.Big_Power
{
    class Program
    {
        static void Main()
        {
            ushort N = ushort.Parse(Console.ReadLine());

            Console.WriteLine(BigInteger.Pow(new BigInteger(N),N));
        }
    }
}
