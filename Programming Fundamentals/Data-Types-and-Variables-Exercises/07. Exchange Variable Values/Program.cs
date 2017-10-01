using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int temp = 0;
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}
