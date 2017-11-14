using System;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main()
        {

            var number = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            long sum = 0;
            for (int i = 0; i < number.Count; i++)
            {
                var temp =ReverseString(number[i]);
                number.RemoveAt(i);
                number.Insert(i, temp);
                sum += int.Parse(number[i]);
            }
            Console.WriteLine(sum);
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
