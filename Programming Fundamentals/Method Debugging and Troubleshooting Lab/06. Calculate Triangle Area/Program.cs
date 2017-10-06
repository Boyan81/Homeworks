using System;

namespace _06._Calculate_Triangle_Area
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(a, h);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double hight)
        {
            return width * hight / 2;
        }
    }
}
