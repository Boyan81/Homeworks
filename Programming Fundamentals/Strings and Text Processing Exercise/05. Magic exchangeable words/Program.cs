﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string wordOne = input[0];
            string wordTwo = input[1];

            char[] arrOne = wordOne.ToCharArray().Distinct().ToArray();
            char[] arrTwo = wordTwo.ToCharArray().Distinct().ToArray();

            if (arrOne.Length==arrTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
