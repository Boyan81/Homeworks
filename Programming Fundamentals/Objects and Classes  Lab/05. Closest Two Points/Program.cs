using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
            int n = int.Parse(Console.ReadLine());
            List<Point> point = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var p = ReadPoint();
                point.Add(p);
            }
            double minDistans = double.MaxValue;
            Point p1 = null;
            Point p2 = null;
            for (int i = 0; i < point.Count; i++)
            {
                for (int j = 0; j < point.Count; j++)
                {
                    if (i!=j)
                    {
                        double curentDistans = Calcolate(point[i], point[j]);
                        if (curentDistans<minDistans)
                        {
                            minDistans = curentDistans;
                            p1 = point[i];
                            p2 = point[j];
                        }
                    }
                }

            }
            Console.WriteLine($"{minDistans:f3}");
            Console.WriteLine("({0}, {1})",p1.X,p1.Y);
            Console.WriteLine("({0}, {1})",p2.X,p2.Y);

        }

        private static Point ReadPoint()
        {
            string[] point1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Point p1 = new Point();
            p1.X = int.Parse(point1[0]);
            p1.Y = int.Parse(point1[1]);
            return p1;
        }
    }
}
