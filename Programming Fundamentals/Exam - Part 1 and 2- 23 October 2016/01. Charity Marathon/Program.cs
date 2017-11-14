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
            decimal day = decimal.Parse(Console.ReadLine());
            decimal runerCount = decimal.Parse(Console.ReadLine());
            decimal lap = decimal.Parse(Console.ReadLine());
            decimal lapLenght = decimal.Parse(Console.ReadLine());
            decimal capaciti = decimal.Parse(Console.ReadLine());
            decimal monyPerKM = decimal.Parse(Console.ReadLine());
           
            if (runerCount>capaciti*day)
            {
                runerCount=capaciti*day;
            }
            decimal miter =(runerCount * lap * lapLenght);
            decimal totalKM = miter / 1000.0m;
            decimal monyRaised = totalKM * monyPerKM;
            Console.WriteLine($"Money raised: {monyRaised:f2}");
        }
    }
}
