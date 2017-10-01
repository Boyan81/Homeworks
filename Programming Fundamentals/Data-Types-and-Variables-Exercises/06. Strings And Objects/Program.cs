using System;

namespace _06._Strings_And_Objects
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secountName = Console.ReadLine();
            object fullNames = firstName + " " + secountName;
            Console.WriteLine(fullNames);

        }
    }
}
