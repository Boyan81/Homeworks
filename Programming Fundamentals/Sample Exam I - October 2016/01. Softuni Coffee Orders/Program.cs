using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totallSum = 0.0m; 
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsul = decimal.Parse(Console.ReadLine());
                DateTime mont = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulCount = long.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(mont.Year, mont.Month);
                decimal curentSum = (days * capsulCount )* pricePerCapsul;
                Console.WriteLine($"The price for the coffee is: ${curentSum:f2}");
                totallSum += curentSum;
            }
            Console.WriteLine($"Total: ${totallSum:f2}");


        }
    }
}
