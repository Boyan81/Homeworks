using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main()
        {
            double inputTemp = double.Parse(Console.ReadLine());

            double celsi = FahrenheitToCelsius(inputTemp);
            Console.WriteLine($"{celsi:f2}");
        }

        static double FahrenheitToCelsius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }
}
