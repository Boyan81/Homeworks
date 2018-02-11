using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Anonymous_Vox
{
    class Program
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            string[] pleas = Console.ReadLine()
                .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"([a-zA-Z]+)(.*)\1";
            int start = 0;
            foreach (Match m in Regex.Matches(input.ToString(), pattern))
            {
                for (int i = start; i < pleas.Length; i++)
                {

                    input.Replace(m.Groups[2].ToString(), pleas[i]);
                    start++;
                    break;
                }
            }
            Console.WriteLine(input);
        }
    }
}
