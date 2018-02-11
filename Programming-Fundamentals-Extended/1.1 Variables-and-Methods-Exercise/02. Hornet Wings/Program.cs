using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Wings
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            decimal M = decimal.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            decimal metersTraveled = (N / 1000) * M;
            int hornetFlaps = N / 100;
            int secondsPassed = (N / P) * 5 + hornetFlaps;
            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondsPassed} s.");

        }
    }
}
