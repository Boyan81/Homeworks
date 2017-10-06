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
            string newFacturiel = factoriel.ToString();
            int count = 0;
            for (int i = newFacturiel.Length - 1; i >= 0; i--)
            {
                if (newFacturiel[i] == '0')
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(count);
        }
    }
}