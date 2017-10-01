using System;
using System.Linq;


namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main()
        {
            //Create a program to check if given symbol is digit, vowel or any other symbol.
            char digit = char.Parse(Console.ReadLine());

            if (char.IsDigit(digit))
            {
                Console.WriteLine("digit");
            }
            else if ("aeiou".Contains(digit))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
