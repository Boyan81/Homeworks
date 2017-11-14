using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
              int[] arr = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int k = arr.Length / 4;
                int[] leftArr = arr.Take(k).ToArray();
                Array.Reverse(leftArr);
                int[] midleArr = arr.Skip(k).Take(k * 2).ToArray();
                int[] rightArr = arr.Skip(k * 3).Take(k).ToArray();
                Array.Reverse(rightArr);
                int[] sum = new int[k * 2];

                for (int i = 0; i < k; i++)
                {
                    sum[i] = leftArr[i] + midleArr[i];
                    sum[k + i] = rightArr[i] + midleArr[k + i];
                }
                Console.WriteLine(String.Join(" ", sum));

            

        }
    }
}
