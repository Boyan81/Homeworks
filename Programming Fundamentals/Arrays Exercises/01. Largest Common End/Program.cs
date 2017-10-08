using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] secoundArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int left = RightAndLeftCheck(firstArr, secoundArr);
            Array.Reverse(firstArr);
            secoundArr = secoundArr.Reverse().ToArray();
            int right = RightAndLeftCheck(firstArr, secoundArr);
            Console.WriteLine($"{Math.Max(left,right)}");

        }

        private static int RightAndLeftCheck(string[] firstArr, string[] secoundArr)
        {
            int lengthArr = Math.Min(firstArr.Length, secoundArr.Length);
            int count = 0;
            for (int i = 0; i < lengthArr; i++)
            {
                if (firstArr[i] == secoundArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
