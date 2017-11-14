using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {

        static void Main()
        {
            int[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            bool isAmount = false;
            for (int i = inputArr.Length - 1; i >= 0; i--)
            {
                if (inputArr[i] == n)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += inputArr[j];
                    }
                    isAmount = true;
                    break;
                }
            }
            if (isAmount)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }

    }
}

