using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigit(number);
            int oddSum = GetSumOfOddDigit(number);
            return oddSum * evenSum;

        }
        static int GetSumOfOddDigit(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit%2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

       static int GetSumOfEvenDigit(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit%2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
            
        }

    }
}
