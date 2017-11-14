using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length);
                string rem = words[index];
                int newIndex = rnd.Next(0, words.Length);
                words[index] = words[newIndex];
                words[newIndex] = rem;
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

        }
    }
}
