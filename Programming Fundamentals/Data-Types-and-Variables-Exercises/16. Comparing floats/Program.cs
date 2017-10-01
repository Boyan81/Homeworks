using System;

namespace _16._Comparing_floats
{
    class Program
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double precisio = 0.000001;
            double difference = Math.Abs(num1 - num2);
            Console.WriteLine(difference<precisio);

        }
    }
}
