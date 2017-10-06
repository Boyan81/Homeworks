using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            OneLine(n);
            MidleLine(n);
            OneLine(n);

        }

        static void OneLine(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void MidleLine(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < (n * 2 - 2) / 2; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
