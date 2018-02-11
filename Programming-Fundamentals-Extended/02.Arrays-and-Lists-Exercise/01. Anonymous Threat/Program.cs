using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Threat
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input;
            while ((input=Console.ReadLine())!="3:1")
            {
                string[] comands = input.Split().ToArray();
                string comand = comands[0];
                switch(comand)
                {
                    case "merge":
                        Merge(words, comands);
                        break;
                    case "divide":
                        Divide(words, comands);
                        break;
                }

            }
            Console.WriteLine(String.Join(" ",words));
        }

        private static void Divide(List<string> words, string[] comands)
        {
            int index = int.Parse(comands[1]);
            int partitions = int.Parse(comands[2]);
            string temp = words[index];
            words.RemoveAt(index);
            int partiton = temp.Length / partitions;
            List<string> leter = new List<string>();
            for (int i = 0; i < partitions; i++)
            {
                if (i==partitions-1)
                {
                    leter.Add(temp.Substring(i * partiton));
                }
                else
                {
                    leter.Add(temp.Substring(i * partiton, partiton));

                }
            }
            words.InsertRange(index, leter);
            
        }

        private static void Merge(List<string> words, string[] comands)
        {
            int startIndex =int.Parse(comands[1]);
            int endIndex = int.Parse(comands[2]);
            if (startIndex<0||startIndex>words.Count-1)
            {
                startIndex = 0;
            }
            if (endIndex<0||endIndex>= words.Count)
            {
                endIndex = words.Count - 1;
            }
            int oder=0;
            if (startIndex==0)
            {
                oder = 1;
            }
            string[]tempWord = words.Skip(startIndex).Take(endIndex+oder).ToArray();
            string word = String.Join("", tempWord);
            int count = endIndex - startIndex+1;
            words.RemoveRange(startIndex, count);
            words.Insert(startIndex, word);
        }
    }
}
