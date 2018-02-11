using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();
            string[] result = new string[input.Length];


            for (int i = 0; i < input.Length-1; i++)
            {
                result[i + 1] = input[i];
                string temp = input[input.Length - 1];
                result[0] = temp;
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
