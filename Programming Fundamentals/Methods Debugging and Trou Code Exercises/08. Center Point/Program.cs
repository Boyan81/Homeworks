using System;

namespace _08._Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Print(x1, y1, x2, y2);
        }

        static void Print(double x1, double y1, double x2, double y2)
        {
            if (Radius(x1, y1) <= Radius(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double Radius(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            return radius;
        }
    }
}
