using System;
using System.Linq;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDay = int.Parse(Console.ReadLine());
            string [] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if (numDay>=1&&numDay<=7)
            {
                Console.WriteLine(day[numDay-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }

}