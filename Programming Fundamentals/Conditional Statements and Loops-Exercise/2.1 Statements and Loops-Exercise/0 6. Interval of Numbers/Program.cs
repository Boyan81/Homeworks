using System;

namespace _0_6._Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int start = 0;
            int end = 0;
            if (num2>num1)
            {
                start = num1;
                end = num2;
            }
            else
            {
                start = num2;
                end = num1;
            }
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
