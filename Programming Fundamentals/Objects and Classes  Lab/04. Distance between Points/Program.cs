using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }

    class Program
    {



        static double Calcolate(Point a, Point b)
        {
            int deltaX = a.X - b.X;
            int deltaY = a.Y - b.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static void Main()
        {
            string[] point1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Point p1 = new Point();
            p1.X = int.Parse(point1[0]);
            p1.Y = int.Parse(point1[1]);

            string[] point2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Point p2 = new Point();
            p2.X = int.Parse(point2[0]);
            p2.Y = int.Parse(point2[1]);

            Console.WriteLine($"{Calcolate(p1, p2):f3}");
        }

    }

}


