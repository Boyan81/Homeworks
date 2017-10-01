using System;

namespace _14._Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            
            string hex = Convert.ToString(num, 16).ToUpper();
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
