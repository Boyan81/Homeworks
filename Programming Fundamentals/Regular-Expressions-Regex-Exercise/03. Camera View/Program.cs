using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main()
        {
            int[] indices = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            int m = indices[0];
            int n = indices[1];

            string pattern = $"\\|\\<(.{{0,{m}}})(.{{0,{n}}})";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            List<string> result = new List<string>();

            while (input.Length > match.Index + 2 && match.Success)
            {
                string mathToAdd = match.Groups[2].Value;
                if (mathToAdd.Contains("|"))
                {
                    mathToAdd = mathToAdd.Substring(0, mathToAdd.IndexOf("|"));
                }
                if (mathToAdd.Contains("<"))
                {
                    mathToAdd = mathToAdd.Substring(0, mathToAdd.IndexOf("<"));
                }
                result.Add(mathToAdd);
                input = input.Substring(match.Index + 2);
                match = regex.Match(input);
            }
            Console.WriteLine(String.Join(", ",result));
        }
    }
}
