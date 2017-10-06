using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input=="int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first,second));
            }
            else if (input=="char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine((char)GetMax(first, second));
            }
            else if (input=="string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first,second));
            }
        }

        static string GetMax(string first, string second)
        {
            int result = string.Compare(first, second);
            if (result>0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }


        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}
