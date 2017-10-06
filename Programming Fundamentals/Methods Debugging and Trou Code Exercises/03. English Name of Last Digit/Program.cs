using System;

namespace _03._English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(EnglishLastDigit(number));
        }

        static string EnglishLastDigit(long num)
        {
            num = Math.Abs(num);
            int lastDigit = (int)(num % 10);
            string[] namDigit = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            return namDigit[lastDigit];
        }
    }
}
