using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace _01._Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> index = new List<int>();

            string pattern = @"\[([a-zA-Z]+)<(\d+)REGEH(\d+)>([a-zA-Z]+)\]";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string firstGr = match.Groups[2].ToString();
                int firstNum = int.Parse(firstGr);
                index.Add(firstNum);
                string secondGr = match.Groups[3].ToString();
                int secondNum = int.Parse(secondGr);
                index.Add(secondNum);
            }
            string rezult = string.Empty;
            int sum = 0;

            for (int i = 0; i < index.Count; i++)
            {
                sum += index[i];
                if (sum > input.Length - 1)
                {
                    int currenIndex = sum - input.Length - 1;
                    rezult += input.Substring(currenIndex,1);
                }
                else
                {
                    rezult += input.Substring(sum,1);
                }
            }
            Console.WriteLine(rezult);
        }
    }
}
