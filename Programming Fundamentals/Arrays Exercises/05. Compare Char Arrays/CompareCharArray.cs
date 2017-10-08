using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class CompareCharArray
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            CompareArray(firstArr, secondArr);
        }

        private static void CompareArray(char[] first, char[] secound)
        {
            int leghtArr = Math.Min(first.Length, secound.Length);
            if (first.Length < secound.Length)
            {
                Console.WriteLine($"{String.Join("", first)}");
                Console.WriteLine($"{String.Join("", secound)}");
            }
            else if (first.Length > secound.Length)
            {
                Console.WriteLine($"{String.Join("", secound)}");
                Console.WriteLine($"{String.Join("", first)}");
            }
            else
            {

                if (first[0] < secound[0])
                {
                    Console.WriteLine($"{String.Join("", first)}");
                    Console.WriteLine($"{String.Join("", secound)}");
                }
                else
                {
                    Console.WriteLine($"{String.Join("", secound)}");
                    Console.WriteLine($"{String.Join("", first)}");
                }

            }
        }
    }
}
