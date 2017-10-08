using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[arr.Length];


            for (int i = 0; i < k; i++)
            {
                arr = shiftRight(arr);

                for (int j = 0; j < arr.Length; j++)
                {

                    sum[j] += arr[j];
                }

            }
            Console.WriteLine(String.Join(" ", sum));

        }
        private static int[] shiftRight(int[] arr)
        {
            int[] demo = new int[arr.Length];

            for (int i = 1; i < arr.Length; i++)
            {
                demo[i] = arr[i - 1];
            }

            demo[0] = arr[demo.Length - 1];

            return demo;
        }
    }
}
