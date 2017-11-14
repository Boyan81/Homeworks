using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string[] input = Console.ReadLine()
                .Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string paterrn = "\\b"+word+"\\b";

            Regex result = new Regex(paterrn);

            foreach (var tem in input)
            {
                if (result.IsMatch(tem))
                {
                    Console.WriteLine(tem.Trim());
                }
            }

        }
    }
}
