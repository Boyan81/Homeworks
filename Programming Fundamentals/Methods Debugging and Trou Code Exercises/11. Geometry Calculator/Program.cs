using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pafigures = Console.ReadLine();


            Console.WriteLine($"{AreaResult(pafigures):f2}");
        }

        static double AreaResult(string pafigures)
        {
            double area = 0;
            if (pafigures == "circle")
            {
                area = AreaCircle();
            }
            else if (pafigures == "rectangle")
            {
                area = AreaRectangle();
            }
            else if (pafigures == "square")
            {
                area = AreaSquare();
            }
            else if (pafigures == "triangle")
            {
                area = AreaTriangle();
            }
            return area;
        }

        static double AreaCircle(double r = 0.0)
        {
            r = double.Parse(Console.ReadLine());
            return Math.PI * Math.Pow(r, 2);
        }

        static double AreaRectangle(double a = 0.0, double b = 0.0)
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            return a * b;
        }

        static double AreaSquare(double a = 0.0)
        {
            a = double.Parse(Console.ReadLine());
            return Math.Pow(a, 2);
        }

        static double AreaTriangle(double a = 0.0, double h = 0.0)
        {
            a = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            return a * h / 2.0;
        }
    }
}
