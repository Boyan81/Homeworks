using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                             .Split(new char[] {',' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(x=>x.Trim())
                             .ToArray();
            string patternValid = @"([@$^#]{6,10}).+\1";
            string patternJacpot = @"^([@$^#]{10,})\1$";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length<20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    if (Regex.IsMatch(input[i],patternJacpot))
                    {
                        var mach = Regex.Match(input[i], patternJacpot).Groups[1].ToString();
                        var ch = mach.First();
                        Console.WriteLine($"ticket \"{input[i]}\" - {mach.Length}{ch} Jackpot!");
                    }
                    else if (Regex.IsMatch(input[i],patternValid))
                    {
                        var mach = Regex.Match(input[i], patternValid).Groups[1].ToString();
                        var ch = mach.First();
                        Console.WriteLine($"ticket \"{input[i]}\" - {mach.Length}{ch}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    }
                }
            }
        }
    }
}
