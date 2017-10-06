using System;


namespace _02.Max_Method
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(num1, num2, num3));
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int max = 0;
            max = Math.Max(num1, num2);
            max = Math.Max(max, num3);
            return max;
        }
    }
}
