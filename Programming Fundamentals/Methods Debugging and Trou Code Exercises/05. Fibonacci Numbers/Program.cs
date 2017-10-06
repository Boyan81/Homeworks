using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Fib(num);
        }

        static void Fib(int num)
        {
            int a = 1;
            int b = 1;
            for (int i = 0; i < num; i++)
            {
                int newB = a + b;
                a = b;
                b = newB;
            }
            Console.WriteLine(a);
        }
    }
}
