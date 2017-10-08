using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var num2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLength = Math.Max(num1.Length, num2.Length);
            int[] result = new int[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                result[i] = num1[i % num1.Length] + num2[i % num2.Length];
            }
            //foreach (var item in result)
            //{
            //    Console.Write(item +" ");
            //}
            //Console.WriteLine();
            //-----------------------
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
