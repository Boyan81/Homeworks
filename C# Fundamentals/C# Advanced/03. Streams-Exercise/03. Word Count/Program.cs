using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Word_Count
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            string inputWords = File.ReadAllText("../Resources/words.txt");
            string[] words = inputWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!countWords.ContainsKey(words[i]))
                {
                    countWords.Add(words[i].ToLower(), 0);
                }
            }

            using (StreamReader readText = new StreamReader("../Resources/text.txt"))
            {
                string line;
                while ((line=readText.ReadLine())!=null)
                {
                    string pattern = @"\w+";

                    foreach (Match match in Regex.Matches(line, pattern))
                    {
                        string currentWord = match.ToString().ToLower();
                        if (countWords.ContainsKey(currentWord))
                        {
                            countWords[currentWord]++;
                        }
                    }
                }
            }
            countWords = countWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            using (StreamWriter writeResult = new StreamWriter("result.txt"))
            {
                foreach (var item in countWords)
                {
                    writeResult.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
