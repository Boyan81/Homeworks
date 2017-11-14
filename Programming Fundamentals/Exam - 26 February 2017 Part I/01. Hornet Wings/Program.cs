using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            long p = long.Parse(Console.ReadLine());

            double distance = (n / 1000) * m;
            Console.WriteLine($"{distance:f2} m.");

            double timePause = (n / p) * 5;
            double alltime = (n / 100.0)+timePause;
            Console.WriteLine($"{alltime} s.");
        }
    }
}
