using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length>second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            }
            else
            {
                first= first.PadLeft(second.Length, '0');
            }
            StringBuilder result = new StringBuilder();
            var sum = 0;
            var remainder = 0;
            var number = 0;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = first[i]-48 + second[i]-48+remainder;
                number = sum % 10;
                result.Append(number);
                remainder = sum / 10;
                if (i==0&&remainder>0)
                {
                    result.Append(remainder);
                }

            }
            Console.WriteLine(new string(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}

