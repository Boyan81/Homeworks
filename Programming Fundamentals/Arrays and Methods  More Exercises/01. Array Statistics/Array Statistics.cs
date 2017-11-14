using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    public class Program
    {
        public static void Main()
        {
            int[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int min = inputArr.Min();
            int max = inputArr.Max();
            int sum = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                sum += inputArr[i];
            }
            double average = sum*1.0 / inputArr.Length * 1.0;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");

        }
    }
}
