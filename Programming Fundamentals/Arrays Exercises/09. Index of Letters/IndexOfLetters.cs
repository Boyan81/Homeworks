using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToArray();

            char[] alphabet = new char[26];
            for (int i = 0; i <alphabet.Length; i++)
            {
                alphabet[i] = (char)(97+i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (arr[i]==alphabet[j])
                    {
                        Console.WriteLine($"{(char)arr[i]} -> {j}");
                    }
                }
            }
        }
    }
}
