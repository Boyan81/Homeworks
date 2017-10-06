using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        static bool IsPrime(long num)
        {
            bool intPrime = true;
            if (num <= 1)
            {
                intPrime = false;
            }

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    intPrime = false;
                    break;
                }

            }
            return intPrime;
        }
    }
}
