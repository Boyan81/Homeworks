using System;

namespace _03._Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            char firstSymbol = char.Parse(Console.ReadLine());
            char secountSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine(firstSymbol);
            Console.WriteLine(secountSymbol);
            Console.WriteLine(thirdSymbol);
            Console.WriteLine(text);
        }
    }
}
