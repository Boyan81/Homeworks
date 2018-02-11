using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double heavyWinds  = double.Parse(Console.ReadLine());

            double consumption = (distance - heavyWinds ) * 25;
            double heavyLitre = heavyWinds * (25 * 1.5);
            double totalConssumption  = (consumption + heavyLitre)*0.05+ (consumption + heavyLitre);
            Console.WriteLine($"Fuel needed: {totalConssumption:f2}L");
            if (totalConssumption<=tankCapacity)
            {
                double result = tankCapacity - totalConssumption;
                Console.WriteLine($"Enough with {result:f2}L to spare!");
            }
            else
            {
                double result = totalConssumption - tankCapacity;
                Console.WriteLine($"We need {result:f2}L more fuel.");
            }
        }
    }
}
