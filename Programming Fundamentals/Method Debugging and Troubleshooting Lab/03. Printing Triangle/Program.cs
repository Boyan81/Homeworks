using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            
            int end = int.Parse(Console.ReadLine());

            PrintingTriangle(end);
        }

        static void PrintingTriangle( int end)
        {
            for (int i = 1; i <= end; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = end; i >= 1; i--)
            {

                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
