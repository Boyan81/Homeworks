﻿using System;

namespace _17._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write("{0} ",(char)i);
            }
            Console.WriteLine();
        }
    }
}
