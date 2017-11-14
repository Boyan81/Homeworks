using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime starDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime
                 .ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidey =
            {
                DateTime
                .ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime
                .ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            };
            int countDay = 0;
           
            for (DateTime curentData = starDate; curentData <= endDate; curentData = curentData.AddDays(1))
            {
                if (curentData.DayOfWeek!=DayOfWeek.Saturday&&curentData.DayOfWeek!=DayOfWeek.Sunday)
                {
                    bool notHolidey = true;

                    foreach (var holideis in holidey)
                    {
                        if (curentData.Day==holideis.Day&&curentData.Month==holideis.Month)
                        {
                            notHolidey = false;
                            break;
                        }
                    }
                    if (notHolidey)
                    {
                        countDay++;
                    }
                    
                }
            }
            Console.WriteLine(countDay);
        }
    }
}
