using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine()
                                , "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());
                totalPrice += OrderPrice(date,capsulesCount,pricePerCapsule);
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

        private static decimal OrderPrice(DateTime date, decimal capsulesCount, decimal pricePerCapsule)
        {
            int dayMonth  = DateTime.DaysInMonth(date.Year, date.Month);
            decimal price = price = (dayMonth * capsulesCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");
            return price;
        }
    }
}
