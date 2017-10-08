using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i+1; j <num.Length; j++)
                {
                    int sum = num[i] + num[j];
                    if (num.Contains(sum))
                    {
                        Console.WriteLine($"{num[i]} + {num[j]} == {sum}");
                        count++;
                    }
                }
            }
            if (count==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
