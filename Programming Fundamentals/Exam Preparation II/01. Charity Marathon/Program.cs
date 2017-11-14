using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main()
        {
            decimal days = decimal.Parse(Console.ReadLine());
            decimal runerCount = decimal.Parse(Console.ReadLine());
            decimal laps = decimal.Parse(Console.ReadLine());
            decimal lapLenghtPerMiter = decimal.Parse(Console.ReadLine());
            decimal trackCapacity = decimal.Parse(Console.ReadLine());
            decimal monyPerKM = decimal.Parse(Console.ReadLine());
           
            if (runerCount>=trackCapacity*days)
            {
                runerCount = trackCapacity*days;
            }
           

            var totalMiter = runerCount * lapLenghtPerMiter*laps;
            var totalKM = totalMiter / 1000.0m;
            var monyMaraton = totalKM * monyPerKM;
            Console.WriteLine($"Money raised: {monyMaraton:f2}");
        }
    }
}
