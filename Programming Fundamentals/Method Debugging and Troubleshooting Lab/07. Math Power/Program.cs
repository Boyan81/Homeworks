using System;

namespace _07._Math_Power
{
    class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(RiseToPower(num, pow));
        }

        static double RiseToPower(double number, int pow)
        {
            double result = 0.0;
            result = number;
            for (int i = 2; i <= pow; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
