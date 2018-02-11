using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Group_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse).ToArray();
            int[] size = new int[3];
            foreach (var number in numbers)
            {
                int ind = Math.Abs(number % 3);
                size[ind]++;
            }

            int[][] jaggedArrey = new int[3][];

            for (int count = 0; count < size.Length; count++)
            {
                jaggedArrey[count] = new int[size[count]];
            }
            int[] index = new int[3];
            foreach (var num in numbers)
            {
                int remander = Math.Abs(num % 3);
                jaggedArrey[remander][index[remander]] = num;
                index[remander]++;
            }
            for (int i = 0; i < jaggedArrey.Length; i++)
            {
                Console.WriteLine(String.Join(" ",jaggedArrey[i]));
            }
        }
    }
}
