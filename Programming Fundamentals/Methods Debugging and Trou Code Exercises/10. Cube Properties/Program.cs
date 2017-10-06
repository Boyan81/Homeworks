using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            a = Math.Abs(a);
            string parameter = Console.ReadLine();

            Print(a, parameter);
        }

        static void Print(double a, string parameter)
        {
            if (parameter == "face")
            {
                Console.WriteLine($"{FaceDiagonals(a):f2}");
            }
            else if (parameter == "space")
            {
                Console.WriteLine($"{SpaceDiagonals(a):f2}");
            }
            else if (parameter == "volume")
            {
                Console.WriteLine($"{Volume(a):f2}");
            }
            else if (parameter == "area")
            {
                Console.WriteLine($"{SurfaceArea(a):f2}");
            }
        }

        static double SurfaceArea(double a)
        {
            return Math.Pow(a, 2) * 6;
        }

        static double Volume(double a)
        {
            return Math.Pow(a, 3);
        }

        static double SpaceDiagonals(double a)
        {
            return Math.Sqrt((a * a) * 3);
        }

        static double FaceDiagonals(double a)
        {
            return Math.Sqrt((a * a) * 2);
        }
    }
}
