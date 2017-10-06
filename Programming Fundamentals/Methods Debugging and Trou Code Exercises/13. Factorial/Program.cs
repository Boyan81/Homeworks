using System;
using System.Numerics;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;
            int a = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel *= i;

            }
            Console.WriteLine(factoriel);
        }
    }
}