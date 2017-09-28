using System;

namespace _14.__Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char name1 = char.Parse(Console.ReadLine());
            char name2 = char.Parse(Console.ReadLine());
            char name3 = char.Parse(Console.ReadLine());

            for (int letter1 = name1; letter1 <= name2; letter1++)
            {
                for (int letter2 = name1; letter2 <= name2; letter2++)
                {
                    for (int letter3 = name1; letter3 <= name2; letter3++)
                    {
                        if (letter1 != name3 && letter2 != name3 && letter3 != name3)
                        {
                            Console.Write("{0}{1}{2} ", (char)letter1, (char)letter2, (char)letter3);
                           

                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
