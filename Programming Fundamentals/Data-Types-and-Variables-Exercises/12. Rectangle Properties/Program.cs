using System;

namespace _12._Rectangle_Properties
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double perimeter = width * 2 + hight * 2;
            double area = width * hight;
            double diagonal = Math.Sqrt(Math.Pow(width,2) + Math.Pow(hight,2));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);

        }
    }
}
