using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ').ToArray();
            string one = input[0];
            string two = input[1];

            int minLenght = Math.Min(one.Length, two.Length);
            int sum = 0;
            for (int i = 0; i < minLenght; i++)
            {
                sum += one[i] * two[i];
            }
            string rem = "";
            if (one.Length>two.Length)
            {
                rem = one.Substring(minLenght);
            }
            else if (one.Length<two.Length)
            {
                rem = two.Substring(minLenght);
            }
            foreach (var ch in rem)
            {
                sum += ch;
            }
            Console.WriteLine(sum);
        }
    }
}
