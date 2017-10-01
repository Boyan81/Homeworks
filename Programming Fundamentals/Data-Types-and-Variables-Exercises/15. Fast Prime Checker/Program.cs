using System;

namespace _15._Fast_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool current = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        current = false;
                        break;
                        
                    }
                    
                }
                Console.WriteLine($"{i} -> {current}");
            }

        }
    }
}
