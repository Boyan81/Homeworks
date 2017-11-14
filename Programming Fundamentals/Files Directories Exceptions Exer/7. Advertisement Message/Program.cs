using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _7.Advertisement_Message
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            string outputName = NameOutput();

            while (!reader.EndOfStream)
            {
                int input = int.Parse(reader.ReadLine());
                

                string[] phrases = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };
                string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
                string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
                string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

                
                Random rnd = new Random();

                for (int i = 0; i < input; i++)
                {
                    File.AppendAllText(outputName, $"{phrases[rnd.Next(phrases.Length)]} {events[rnd.Next(events.Length)]} {authors[rnd.Next(authors.Length)]} - {cities[rnd.Next(cities.Length)]}"+Environment.NewLine);
                                   
                }
            }
            reader.Close();
        }
        private static string NameOutput()
        {
            var number = Directory.GetFiles(@"..\..\")//-текуща директория кадето са фаиловете
                .Where(f => f.StartsWith(@"..\..\output"))//-намираме всички фаилове които стартират с output
                .Select(f => f.Split('_').Skip(1).FirstOrDefault())//-
                .Where(f => f != null)//-
                .Select(f => f.Replace(".txt", ""))//-
                .Select(int.Parse);

            int nextNumber = 0;
            if (number.Any())
            {
                nextNumber = number.Max() + 1;
            }
            string outputName = @"..\..\output_" + nextNumber + ".txt";
            return outputName;
        }
    }
}
