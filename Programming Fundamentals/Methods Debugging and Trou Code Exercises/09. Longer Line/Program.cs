using System;

namespace _09._Longer_Line
{
    class Program
    {

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            

            if (lineLength(x1,y1,x2,y2)>=lineLength(x3,y3,x4,y4))
            {
                Print(x1, y1,x2,y2);
            }
            else
            {
                Print(x3, y3, x4, y4);
            }



        }
        static double lineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }


        static void Print(double x1, double y1, double x2, double y2)
        {
            if (Radius(x1, y1) <= Radius(x2, y2))
            {
                string minRadius = ($"({x1}, {y1})");
                string maxRadius = ($"({x2}, {y2})");
                Console.WriteLine(minRadius+maxRadius);
            }
            else
            {
                string minRadius = ($"({x2}, {y2})");
                string maxRadius = ($"({x1}, {y1})");
                Console.WriteLine(minRadius + maxRadius);

            }
        }

        static double Radius(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            return radius;
        }
    }

}
