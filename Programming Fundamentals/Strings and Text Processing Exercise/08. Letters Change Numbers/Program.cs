using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = "A12b";

            StringBuilder wordUP = new StringBuilder();
            StringBuilder wordSm = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                wordUP.Append((char)(i + 65));
            }
            for (int i = 0; i < 26; i++)
            {
                wordSm.Append((char)(i + 97));
            }
            string num = input.Skip(1).Take(2).ToString();
            double number = double.Parse(num);
            string upWord = wordUP.ToString();
            string smWord = wordSm.ToString();
            string firstWord = input[0].ToString();
            string lastWord = input.Last().ToString();
            var indexUP = upWord.IndexOf(firstWord);
            

            

            Console.WriteLine(wordUP);
        }
    }
}
