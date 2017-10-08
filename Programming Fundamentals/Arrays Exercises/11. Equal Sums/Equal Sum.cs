using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFindEqual = false;
            for (int i = 0; i < inputArr.Length; i++)
            {
                int[] leftArr = inputArr.Take(i).ToArray();
                int[] right = inputArr.Skip(i + 1).ToArray();
                if (leftArr.Sum()==right.Sum())
                {
                    Console.WriteLine(i);
                    isFindEqual = true;
                    break;
                }
            }
            if (!isFindEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
