using System;

namespace _05._Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newWord = null;

            if (word.EndsWith("y"))
            {
                newWord = word.Remove(word.Length-1);
                newWord = newWord + "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") ||
                     word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                newWord = word + "es";

            }
            else
            {
                newWord = word + "s";
            }
            Console.WriteLine(newWord);
        }
    }
}
