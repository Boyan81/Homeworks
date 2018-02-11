using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parenthesis
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }
            char[] opening = new char[] { '(', '[', '{' };
            char[] clousing = new char[] { ')', ']', '}' };

            var steck = new Stack<char>();

            foreach (var item in input)
            {
                if (opening.Contains(item))
                {
                    steck.Push(item);
                }
                else if (clousing.Contains(item))
                {
                    var lastElements = steck.Pop();
                    int openingIndex = Array.IndexOf(opening, lastElements);
                    int clousIndex = Array.IndexOf(clousing, item);

                    if (openingIndex!=clousIndex)
                    {   
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
            }
            if (steck.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
