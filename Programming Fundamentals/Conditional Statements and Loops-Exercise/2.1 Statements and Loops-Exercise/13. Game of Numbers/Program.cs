using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int num1 = M; num1 >=N; num1--)
            {
                for (int num2 = N; num2 <=M; num2++)
                {
                    sum = num1 + num2;
                    count++;
                    if (sum==magicalNum)
                    {
                        Console.WriteLine($"Number found! {num1} + {num2} = {magicalNum}");
                        return;
                    }
                    else
                    {
                        sum = 0;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicalNum}");
        }
    }
}
