using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([a-zA-Z]|\D+)(\d+)";
            string grup1 = "";
            int count = 0;
            StringBuilder output = new StringBuilder();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                grup1 = m.Groups[1].Value;
                count = int.Parse(m.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    output.Append(grup1.ToUpper());
                }
            }
            int countChar = output.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {countChar}");
            Console.WriteLine(output);
        }
    }
}
